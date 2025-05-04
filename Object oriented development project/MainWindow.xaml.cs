using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Object_oriented_development_project
{
    public partial class MainWindow : Window
    {
        private Player player;
        private Enemy currentEnemy;
        private Random random;
        private RoomData roomContext;

        private int playerDamage;
        private int healingFlasks;

        //Im using a list so that the game knows what the names for the doors are in the databases
        private List<string> doorTypes = new List<string> { "Wooden", "Iron", "Stone", "Ornate", "Rusty", "Golden", "Emerald", "Charred", "Bronze", "Runic", "Eldritch", "Abyssal", "Void", "Crystal", "Bone", "Clockwork", "Veil", "Blood", "Mirror" };
        //this string is what is used to show the text describing the rooms 
        string fullDescription = "";

        public MainWindow()
        {
            //when the player opens the game, it begins by creating a new player object along with setting up random
            InitializeComponent();
            player = new Player();
            random = new Random();
            roomContext = new RoomData();

            playerDamage = 10;
            healingFlasks = 3;
            AssignRandomDoors();
            UpdatePlayerUI();
        }

        private void UpdatePlayerUI()
        {
            PlayerHealthText.Text = $"Health: {player.Health}";
            PlayerScoreText.Text = $"Score: {player.Score}";
        }


        private void DoorButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string chosenDoorType = clickedButton.Content.ToString();

            DisplayRoomDescription(chosenDoorType);

            EnemyEncounter();

            // After each encounter ends, thh player then gets to pick new randomised doors
            AssignRandomDoors();
        }

        

        //This method assigns three random doors to the buttons
        private void AssignRandomDoors()
        {
            //It starts by shuffling the door types
            var shuffledDoors = doorTypes.OrderBy(x => random.Next()).ToList();

            //Then it goes on to pick the first three
            DoorButton1.Content = shuffledDoors[0];
            DoorButton2.Content = shuffledDoors[1];
            DoorButton3.Content = shuffledDoors[2];
        }

        //This method shows the room description
        private void DisplayRoomDescription(string chosenDoorType)
        {
            
            var rooms = roomContext.Rooms.Where(r => r.Door.DoorType == chosenDoorType).ToList();

            if (rooms.Count == 0)
            {
                RoomDescriptionText.Text = "No rooms found for this door.";
                return;
            }
            //the room descriptions are made up of three parts that are each randomly picked from the database
            var wallsAndItems = rooms.Where(r => r.DescriptionType == "WallsAndItems").ToList();
            var floorAndCeiling = rooms.Where(r => r.DescriptionType == "FloorAndCeiling").ToList();
            var ambience = rooms.Where(r => r.DescriptionType == "Ambience").ToList();


            RoomDescriptionText.Text += "\n\n";
            RoomDescriptionText.Text += $"You go through the {chosenDoorType} door\n As you enter, You notice ";
            if (wallsAndItems.Any())
            {
                var selectedWalls = wallsAndItems[random.Next(wallsAndItems.Count)];
                fullDescription = $"{selectedWalls.RoomDescription}, ";
            }

            if (floorAndCeiling.Any())
            {
                var selectedFloor = floorAndCeiling[random.Next(floorAndCeiling.Count)];
                fullDescription += $"{selectedFloor.RoomDescription}, ";
            }

            if (ambience.Any())
            {
                var selectedAmbience = ambience[random.Next(ambience.Count)];
                fullDescription += $"{selectedAmbience.RoomDescription}, ";
            }

            RoomDescriptionText.Text += fullDescription.Trim();
            RoomdescriptionScrollviewer.ScrollToEnd();
        }

        //This method is used to determine whetehr or not the player encounters an enemy, if they do it runst the StartCombat method
        private void EnemyEncounter()
        {
            int enemyChance = random.Next(1, 101);
            if (enemyChance <= 50)
            {
                StartCombat();
            }
            else
            {
                CombatText.Text = "No enemies were encountered in this room.";
            }
            
        }

        private void StartCombat()
        {
            //at the start of combat the game hides the buttons for choosing the doors
            DoorButton1.Visibility = Visibility.Collapsed;
            DoorButton2.Visibility = Visibility.Collapsed;
            DoorButton3.Visibility = Visibility.Collapsed;

            //then it shows the combat controls
            CombatControls.Visibility = Visibility.Visible;
            currentEnemy = new Enemy { Name = "Goblin", Health = 40, AttackPower = 5 };
            CombatText.Text = $"A wild {currentEnemy.Name} appears! Prepare to fight.";

            AttackButton.Visibility = Visibility.Visible;
            HealButton.Visibility = Visibility.Visible;

            CombatTurn();
        }

        //this method is for when the player encounters anenemy in a room and plays out the combat
        private void CombatTurn()
        {
            if (player.Health <= 0 || currentEnemy.Health <= 0)
                return;

            int damage = random.Next(playerDamage - 2, playerDamage + 2);
            currentEnemy.Health -= damage;
            CombatText.Text += Environment.NewLine + $"You attack {currentEnemy.Name} for {damage} damage.";

            if (currentEnemy.Health <= 0)
            {
                CombatText.Text +=  $"\nYou defeated {currentEnemy.Name}!";
                CombatLogScrollViewer.ScrollToEnd();

                AttackButton.Visibility = Visibility.Collapsed;
                HealButton.Visibility = Visibility.Collapsed;
                DoorButton1.Visibility = Visibility.Visible;
                DoorButton2.Visibility = Visibility.Visible;
                DoorButton3.Visibility = Visibility.Visible;
                player.Score += 10;
                UpdatePlayerUI();
                Reward();
                return;
            }

            int enemyDamage = currentEnemy.Attack();
            player.TakeDamage(enemyDamage);
            CombatText.Text += $"\n{currentEnemy.Name} attacks you for {enemyDamage} damage.";
            CombatLogScrollViewer.ScrollToEnd();


            UpdatePlayerUI();

            if (player.Health <= 0)
            {
                CombatText.Text += "\nYou were defeated! Game Over.";
                CombatLogScrollViewer.ScrollToEnd();

                AttackButton.Visibility = Visibility.Collapsed;
                HealButton.Visibility = Visibility.Collapsed;
                return;
            }
        }

        //Method for when the player chooses to heal in combat
        private void HealPlayer()
        {
            if (healingFlasks > 0)
            {
                player.Health += 10;
                healingFlasks--;
                CombatText.Text += $"\nYou healed yourself for 10 points. Healing flasks remaining: {healingFlasks}.";
                UpdatePlayerUI();
            }
            else
            {
                CombatText.Text += "\nYou have no healing flasks left!";
            }
        }

        //Methods for when the player selects attack or heal while in combat
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTurn();
        }

        private void HealButton_Click(object sender, RoutedEventArgs e)
        {
            HealPlayer();
        }

        //this method is for when a player finishes combat, it determines the reward they get more often than not it will be healing potions but occasionally it will be a new weapon, which increases their damage
        private void Reward()
        {
            string reward = random.NextDouble() < 0.95 ? "Healing Potion" : "Weapon";
            if (reward == "Healing Potion")
            {
                healingFlasks += 2;
                CombatText.Text += "\nYou find 2 Healing Potions!";
            }
            else
            {
                playerDamage += 2;
                CombatText.Text += "\nYou find a new Weapon! Your damage increases.";
            }

            player.Score += 100;
            UpdatePlayerUI();
        }
    }
}
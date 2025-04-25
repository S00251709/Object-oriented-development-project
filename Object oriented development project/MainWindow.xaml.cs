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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player player;
        private Enemy currentEnemy;
        private Random random;
        private RoomData roomContext;

        private int playerDamage;
        private int healingFlasks;

        public MainWindow()
        {
            InitializeComponent();
            player = new Player();
            random = new Random();
            roomContext = new RoomData();

            playerDamage = 10;
            healingFlasks = 3;

            UpdatePlayerUI();
        }

        private void UpdatePlayerUI()
        {
            PlayerHealthText.Text = $"Health: {player.Health}";
            PlayerScoreText.Text = $"Score: {player.Score}";
            InventoryText.Text = $"Inventory: {string.Join(", ", player.Inventory)}";
        }

        private void DoorButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;

            WoodenDoorButton.IsEnabled = false;
            IronDoorButton.IsEnabled = false;
            SteelDoorButton.IsEnabled = false;

            var chosenDoorType = clickedButton.Content.ToString();
            var availableRooms = roomContext.Rooms.Where(r => r.Door.DoorType == chosenDoorType).ToList();

            var chosenRoom = availableRooms[random.Next(availableRooms.Count)];

            RoomDescriptionText.Text = $"You choose the {chosenRoom.DescriptionType} room. The room details are:\n" +
                                       $"{chosenRoom.RoomDescription}";

            EnemyEncounter();
        }

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
            currentEnemy = new Enemy { Name = "Goblin", Health = 40, AttackPower = 5 };
            CombatText.Text = $"A wild {currentEnemy.Name} appears! Prepare to fight.";

            AttackButton.Visibility = Visibility.Visible;
            HealButton.Visibility = Visibility.Visible;

            CombatTurn();
        }

        private void CombatTurn()
        {
            if (player.Health <= 0 || currentEnemy.Health <= 0)
                return;

            int damage = random.Next(playerDamage - 2, playerDamage + 2);  
            currentEnemy.Health -= damage;
            CombatText.Text = $"You attack {currentEnemy.Name} for {damage} damage.";

            if (currentEnemy.Health <= 0)
            {
                CombatText.Text += $"\nYou defeated {currentEnemy.Name}!";
                player.Score += 10;
                UpdatePlayerUI();
                Reward();
                return;
            }

            int enemyDamage = currentEnemy.Attack();
            player.TakeDamage(enemyDamage);
            CombatText.Text += $"\n{currentEnemy.Name} attacks you for {enemyDamage} damage.";

            UpdatePlayerUI();

            if (player.Health <= 0)
            {
                CombatText.Text += "\nYou were defeated! Game Over.";
                AttackButton.Visibility = Visibility.Collapsed;
                HealButton.Visibility = Visibility.Collapsed;
                return;
            }
        }

        // Handle Healing
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

        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            CombatTurn();
        }

        private void HealButton_Click(object sender, RoutedEventArgs e)
        {
            HealPlayer();
        }

        private void Reward()
        {
            string reward = random.NextDouble() < 0.95 ? "Healing Potion" : "Weapon";
            if (reward == "Healing Potion")
            {
                healingFlasks += 2; // Reward the player with 2 healing flasks
                CombatText.Text += "\nYou find 2 Healing Potions!";
            }
            else
            {
                playerDamage += 2; // Reward the player with a stronger weapon
                CombatText.Text += "\nYou find a new Weapon! Your damage increases.";
            }

            // Update score
            player.Score += 100;
            UpdatePlayerUI();
        }
    }
}

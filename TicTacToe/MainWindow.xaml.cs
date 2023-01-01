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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; } = true;

        public int Counter { get; set; } = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NewGame()
        {
            IsPlayer1Turn = true;
            Counter = 0;

            Button_0_0.Content = null;
            Button_1_0.Content = null;
            Button_2_0.Content = null;
            Button_0_1.Content = null;
            Button_1_1.Content = null;
            Button_2_1.Content = null;
            Button_0_2.Content = null;
            Button_1_2.Content = null;
            Button_2_2.Content = null;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;

            return;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (Counter >= 9)
            {
                NewGame();
                return;
            }
            if (button != null && !button.HasContent) 
            {
                button.Content = IsPlayer1Turn? "O" : "X";
                
                Counter++;
                IsPlayer1Turn ^= true;
            }
            
            if (CheckForWin())
            {
                Counter = 9;
                return;
            }





        }
        private bool CheckForWin()
        {
            ////////////////////////////////////////////////////////Horizontal
            if (Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content && Button_0_0.Content != null) 
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }
            if (Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content && Button_1_0.Content != null)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;

            }
            if (Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content && Button_2_0.Content != null)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;

            }
            //////////////////////////////////////////////////////////////Vertical
            if (Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content && Button_0_0.Content != null)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;

            }
            if (Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content && Button_0_1.Content != null)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;

            }
            if (Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content && Button_0_2.Content != null)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;

            }
            /////////////////////////////////////////////////////////////Diagonal
            if (Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content && Button_0_0.Content != null)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;

            }
            if (Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content && Button_0_2.Content != null)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;

            }


            return false;
        }
    }
}

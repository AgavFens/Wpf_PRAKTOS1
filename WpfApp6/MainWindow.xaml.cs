using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{

    public partial class MainWindow : Window
    {
        int randombuttondlyabotyari;
        public Button[] knopki;
        int win = 666;
        int count;
        public MainWindow()
        {
            InitializeComponent();
            knopki = new Button[9] {q1, q2, q3, q4, q5, q6, q7 ,q8, q9};
        }
        public void BOTYRA()
        {
            Random random = new Random();
            randombuttondlyabotyari = random.Next(0, 8);
            while (knopki[randombuttondlyabotyari].IsEnabled == false)
            {
                if (q1.IsEnabled == false && q2.IsEnabled == false && q3.IsEnabled == false && q4.IsEnabled == false && q5.IsEnabled == false && q6.IsEnabled == false && q7.IsEnabled == false && q8.IsEnabled == false && q9.IsEnabled == false)
                {
                    break;
                }
                else
                {
                    randombuttondlyabotyari = random.Next(0, 8);
                }
            }
            knopki[randombuttondlyabotyari].IsEnabled = false;
            knopki[randombuttondlyabotyari].Content = "0";
        }
        public void checkwin()
        {
            if (q1.Content == "0" && q2.Content == "0" && q3.Content == "0" || q2.Content == "0" && q5.Content == "0" && q8.Content == "0" ||
                q7.Content == "0" && q8.Content == "0" && q9.Content == "0" || q4.Content == "0" && q5.Content == "0" && q6.Content == "0" ||
                q3.Content == "0" && q5.Content == "0" && q7.Content == "0" || q1.Content == "0" && q4.Content == "0" && q7.Content == "0" ||
                q1.Content == "0" && q5.Content == "0" && q9.Content == "0" || q3.Content == "0" && q6.Content == "0" && q9.Content == "0")
            {
                win = 0;
            }
            if (q1.Content == "X" && q2.Content == "X" && q3.Content == "X" || q2.Content == "X" && q5.Content == "X" && q8.Content == "X" ||
                q7.Content == "X" && q8.Content == "X" && q9.Content == "X" || q4.Content == "X" && q5.Content == "X" && q6.Content == "X" ||
                q3.Content == "X" && q5.Content == "X" && q7.Content == "X" || q1.Content == "X" && q4.Content == "X" && q7.Content == "X" ||
                q1.Content == "X" && q5.Content == "X" && q9.Content == "X" || q3.Content == "X" && q6.Content == "X" && q9.Content == "X")
            {
                win = 1;
            }
            if (q1.IsEnabled == false && q2.IsEnabled == false && q3.IsEnabled == false && q4.IsEnabled == false && q5.IsEnabled == false && q6.IsEnabled == false && q7.IsEnabled == false && q8.IsEnabled == false && q9.IsEnabled == false)
            {
                win = 2;
            }
        }
        public void SbrosIgri()
        {
            q1.IsEnabled = true; q2.IsEnabled = true; q3.IsEnabled = true; q4.IsEnabled = true; q5.IsEnabled = true; q6.IsEnabled = true; q7.IsEnabled = true; q8.IsEnabled = true; q9.IsEnabled = true;
            q1.Content = ""; q2.Content = ""; q3.Content = ""; q4.Content = ""; q5.Content = ""; q6.Content = ""; q7.Content = ""; q8.Content = ""; q9.Content = "";
            win = 666;
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            BOTYRA();
            checkwin();
            if (win == 1)
            {
                MessageBox.Show("Выйграл чоловек");
                SbrosIgri();
            }
            else if (win == 2)
            {
                MessageBox.Show("Ничья");
                SbrosIgri();
            }
            else if (win == 0)
            {
                MessageBox.Show("Выйграл ботек");
                SbrosIgri();
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            q1.IsEnabled = true; q2.IsEnabled = true; q3.IsEnabled = true; q4.IsEnabled = true; q5.IsEnabled = true; q6.IsEnabled = true; q7.IsEnabled = true; q8.IsEnabled = true; q9.IsEnabled = true;
        }

        private void new_game_Click(object sender, RoutedEventArgs e)
        {
            SbrosIgri();
        }
    }
}
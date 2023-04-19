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

namespace pm04_sysoevad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length < 10 || textBox.Text.Length > 50)
            {
                textBox.Background = Brushes.Red;
                string text = "Недопустимое количество символов";
                textBlock.Text = text;
            }
            else
            {
                textBox.Background = Brushes.Green;
                string text1 = "По красоте";
                textBlock.Text = text1;
            }
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Length < 2 || textBox1.Text.Length > 3)
            {
                textBox1.Background = Brushes.Red;
                string text2 = "Недопустимое количество символов";
                textBlock1.Text = text2;
            }
            else
            {
                textBox1.Background = Brushes.Green;
                string text3 = "По красоте";
                textBlock1.Text = text3;
            }
        }

        private void textBoxminus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (textBoxminus.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }

        private void textBoxminus1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (textBoxminus.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }
    }
}

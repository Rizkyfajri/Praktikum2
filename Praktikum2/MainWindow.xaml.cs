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

namespace Praktikum2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int val1;
        int val2;  
        public MainWindow()
        {
            InitializeComponent();
        }
        //operators
        private void ButtonTambah_Click(object sender, RoutedEventArgs e)
        {
            this.val1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }
        private void buttonHasil_Click_1(object sender, RoutedEventArgs e)
        {
            this.val2 = int.Parse(textBox1.Text);
            int hasil = val1 + val2;
            textBox1.Text = "";
            textBox1.Text = hasil.ToString();
            Console.WriteLine(hasil.ToString());
        }
        //angka

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }


    }
}

﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            Close();
        }
    }
}
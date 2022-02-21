﻿using StudentInformation.FW.ViewModel;
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

namespace StudentInformation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            this.DataContext = ViewModel;
        }

        public MainViewModel ViewModel { get; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Student.Age = 80;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //btn1.Background = Brushes.Green;
            //btn1.Foreground = Brushes.Green;
        }
    }
}

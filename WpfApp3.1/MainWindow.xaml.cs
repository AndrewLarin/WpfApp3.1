﻿using System;
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

namespace WpfApp3._1
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

        private void BoldButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold;
        }

        private void BoldButton_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Regular;
        }

        private void ItalicButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }

        private void Re(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Normal;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Add(TextDecorations.Underline);
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
        }

        private void fontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                double fs = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textBox.FontSize = fs;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fn = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fn);
            }
        }
    }
}

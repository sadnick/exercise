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

namespace exercise
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

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var num1 = Convert.ToDouble(textbox1.Text);
            var num2 = Convert.ToDouble(textbox2.Text);
            var answer = num1 + num2;
            Answer.Text = answer.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var num1 = Convert.ToDouble(textbox1.Text);
            var num2 = Convert.ToDouble(textbox2.Text);

            if (num2 == 0)

            {
                Answer.Text = "Обнаружено деление на ноль";
            }
            else
            {
                var answer = num1 / num2;
                Answer.Text = answer.ToString();
            }
        }


    }
}



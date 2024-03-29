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
using RVP.Task5.Core; using RVP.Task5.View.TaskPages;

namespace RVP.Task5.View.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage6.xaml
    /// </summary>
    public partial class TaskPage6 : Page
    {
        public TaskPage6()
        {
            InitializeComponent();
        }
        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] N = new int[9];
                string[] M = new string[9];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 99);
                    string B = Convert.ToString(k, 8);
                    M[i] = B;
                    N[i] = k;
                }

                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\nРезультат=\n{string.Join(", ", N)}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}

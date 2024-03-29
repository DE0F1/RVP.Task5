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
    /// Логика взаимодействия для TaskPage13.xaml
    /// </summary>
    public partial class TaskPage13 : Page
    {
        public TaskPage13()
        {
            InitializeComponent();
        }
        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
                string[] N = new string[A];
                Random ran = new Random();
                int k, S = 0;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(1, 20);
                    S += k;
                    string B = Convert.ToString(k, 2);
                    N[i] = B;
                }
                S /= A;
                string T = Convert.ToString(S, 2);

                MessageBox.Show($"{string.Join(", ", N)}\n Среднее значение={T}", "Системное сообщение",
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

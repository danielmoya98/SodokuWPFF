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

namespace El_mejor_proyecto_de_tu_vida
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReproductorDePrueba.Source = new Uri(@"D:\Daniel\cursos\UNIVALLE (2).mp4");
            ReproductorDePrueba.Play();
        }

        private void ReproductorDePrueba_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ReproductorDePrueba.Close();
            daniel.NavigationService.Navigate(new Page1());
            
        }
    }
}

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

namespace El_mejor_proyecto_de_tu_vida
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            ReproductorDePrueba.Source = new Uri(@"D:\Daniel\cursos\sor1.wav");
            ReproductorDePrueba.Play();           
        }

        private void btn_dif_Click(object sender, RoutedEventArgs e)
        {
            btn_inipar.Visibility = Visibility.Hidden;
            btn_salir.Visibility = Visibility.Hidden;
            lbl_dificultad.Visibility = Visibility.Visible;
            btn_dif_facil.Visibility = Visibility.Visible;
            btn_dif_nor.Visibility = Visibility.Visible;
            btn_dif_post.Visibility = Visibility.Visible;
        }

        private void btn_opc_Click(object sender, RoutedEventArgs e)
        {
            btn_inipar.Visibility = Visibility.Hidden;
            btn_salir.Visibility = Visibility.Hidden;
            lbl_dificultad.Content = "OPCIONES";
            lbl_dificultad.Visibility = Visibility.Visible;
            btn_opc_oscuro.Visibility = Visibility.Visible;
            /*btn_opc_hud.Visibility = Visibility.Visible;
            btn_opc_univalle.Visibility = Visibility.Visible;*/
            checkbox.Visibility= Visibility.Visible;
            
        }

        private void btn_inipar_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Page3());
            frame.Visibility= Visibility.Visible;
        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

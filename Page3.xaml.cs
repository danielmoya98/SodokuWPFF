using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace El_mejor_proyecto_de_tu_vida
{
    /// <summary>
    /// Lógica de interacción para Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private TextBox[,] textBoxes;
        int contador = 0;
        private System.Diagnostics.Stopwatch stopwatch;
        DispatcherTimer timer = new DispatcherTimer();
        DateTime startTime;


        public Page3()
        {
            InitializeComponent();
            CreateTextBoxMatrix();
            pintarCuandrantes();
            niveles();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;
            timerTex.Content = timeElapsed.ToString(@"hh\:mm\:ss");
        }

        private void iniciar()
        {
            stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += (s, args) =>
            {
                var ts = stopwatch.Elapsed;
                timerTex.Content = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            };
            timer.Start();

        }

        private void pintarCuandrantes()
        {

            for (int i = 0; i < 9; i++)
            {
                textBoxes[0, i].BorderThickness = new Thickness(0.5, 3, 0.5, 0.5);
                textBoxes[0, i].BorderBrush = Brushes.Black;

                textBoxes[2, i].BorderThickness = new Thickness(0.5, 0.5, 0.5, 6);
                textBoxes[2, i].BorderBrush = Brushes.Black;

                
                textBoxes[5, i].BorderThickness = new Thickness(0.5, 0.5, 0.5, 6);
                textBoxes[5, i].BorderBrush = Brushes.Black;

                textBoxes[8, i].BorderThickness = new Thickness(0.5, 0.5, 0.5, 6);
                textBoxes[8, i].BorderBrush = Brushes.Black;

                textBoxes[i, 2].BorderThickness = new Thickness(0.5, 0.5, 6, 0.5);
                textBoxes[i, 2].BorderBrush = Brushes.Black;

                textBoxes[i, 5].BorderThickness = new Thickness(0.5, 0.5, 6, 0.5);
                textBoxes[i, 5].BorderBrush = Brushes.Black;

                textBoxes[i, 0].BorderThickness = new Thickness(3, 0.5, 0.5, 0.5);
                textBoxes[i, 0].BorderBrush = Brushes.Black;

                textBoxes[i, 8].BorderThickness = new Thickness(0.5, 0.5, 6, 0.5);
                textBoxes[i, 8].BorderBrush = Brushes.Black;


            }

            textBoxes[0, 8].BorderThickness = new Thickness(0.5, 3, 6, 0.5);
            textBoxes[0, 8].BorderBrush = Brushes.Black;
            textBoxes[0, 0].BorderThickness = new Thickness(3, 3, 0.5, 0.5);
            textBoxes[0, 0].BorderBrush = Brushes.Black;
            textBoxes[2, 0].BorderThickness = new Thickness(3, 0.5, 0.5, 6);
            textBoxes[2, 0].BorderBrush = Brushes.Black;
            textBoxes[5, 0].BorderThickness = new Thickness(3, 0.5, 0.5, 6);
            textBoxes[5, 0].BorderBrush = Brushes.Black;
            textBoxes[8, 0].BorderThickness = new Thickness(3, 0.5, 0.5, 6);
            textBoxes[8, 0].BorderBrush = Brushes.Black;

            textBoxes[2, 2].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[2, 2].BorderBrush = Brushes.Black;
            textBoxes[5, 2].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[5, 2].BorderBrush = Brushes.Black;
            textBoxes[8, 2].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[8, 2].BorderBrush = Brushes.Black;

            textBoxes[2, 5].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[2, 5].BorderBrush = Brushes.Black;
            textBoxes[5, 5].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[5, 5].BorderBrush = Brushes.Black;
            textBoxes[8, 5].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[8, 5].BorderBrush = Brushes.Black;

            textBoxes[2, 8].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[2, 8].BorderBrush = Brushes.Black;
            textBoxes[5, 8].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[5, 8].BorderBrush = Brushes.Black;
            textBoxes[8, 8].BorderThickness = new Thickness(0.5, 0.5, 6, 6);
            textBoxes[8, 8].BorderBrush = Brushes.Black;

            textBoxes[0, 2].BorderThickness = new Thickness(0.5, 3, 6, 0.5);
            textBoxes[0, 2].BorderBrush = Brushes.Black;
            textBoxes[0, 5].BorderThickness = new Thickness(0.5, 3, 6, 0.5);
            textBoxes[0, 5].BorderBrush = Brushes.Black;
        }

        private void niveles()
        {

            dificultad.Items.Add("Facil");
            dificultad.Items.Add("Normal");
            dificultad.Items.Add("Dificil");
        }




        private void nivelfacil()
        {

            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "3";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "9";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "1";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "5";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "5";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "3";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "2";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "7";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }

        private void nivelfacil1()
        {

            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "2";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "4";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "3";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "9";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "1";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "2";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "5";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "8";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "1";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "8";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "3";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "6";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "1";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "5";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;


            iniciar();
        }

        private void nivelfacil2()
        {
            textBoxes[0, 0].Text = "2";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "1";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "4";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "1";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "1";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "9";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "5";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "2";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "6";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "8";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "1";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "8";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "3";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "6";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "5";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "";
            textBoxes[8, 8].Text = "1";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }

        private void nivelmedio()
        {
            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "2";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "1";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "5";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "3";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }
        private void niveldificil()
        {
            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "8";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "1";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "5";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "2";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }

        private void nivelmedio1()
        {
            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "5";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "1";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "5";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "2";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "9";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }

        private void nivelmedio2()
        {
            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "5";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "2";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "5";
            textBoxes[2, 6].Text = "";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "6";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "6";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "7";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "9";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }
        private void niveldificil1()
        {
            textBoxes[0, 0].Text = "9";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "1";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "4";
            textBoxes[2, 7].Text = "";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "2";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "5";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "3";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "1";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }



        private void niveldificil2()
        {
            textBoxes[0, 0].Text = "1";
            textBoxes[0, 1].Text = "";
            textBoxes[0, 2].Text = "";
            textBoxes[0, 3].Text = "";
            textBoxes[0, 4].Text = "";
            textBoxes[0, 5].Text = "";
            textBoxes[0, 6].Text = "";
            textBoxes[0, 7].Text = "";
            textBoxes[0, 8].Text = "";

            textBoxes[1, 0].Text = "";
            textBoxes[1, 1].Text = "";
            textBoxes[1, 2].Text = "";
            textBoxes[1, 3].Text = "";
            textBoxes[1, 4].Text = "5";
            textBoxes[1, 5].Text = "";
            textBoxes[1, 6].Text = "";
            textBoxes[1, 7].Text = "";
            textBoxes[1, 8].Text = "";

            textBoxes[2, 0].Text = "";
            textBoxes[2, 1].Text = "";
            textBoxes[2, 2].Text = "";
            textBoxes[2, 3].Text = "";
            textBoxes[2, 4].Text = "";
            textBoxes[2, 5].Text = "";
            textBoxes[2, 6].Text = "4";
            textBoxes[2, 7].Text = "1";
            textBoxes[2, 8].Text = "";

            textBoxes[3, 0].Text = "";
            textBoxes[3, 1].Text = "";
            textBoxes[3, 2].Text = "";
            textBoxes[3, 3].Text = "";
            textBoxes[3, 4].Text = "";
            textBoxes[3, 5].Text = "6";
            textBoxes[3, 6].Text = "";
            textBoxes[3, 7].Text = "";
            textBoxes[3, 8].Text = "";

            textBoxes[4, 0].Text = "";
            textBoxes[4, 1].Text = "";
            textBoxes[4, 2].Text = "";
            textBoxes[4, 3].Text = "";
            textBoxes[4, 4].Text = "";
            textBoxes[4, 5].Text = "";
            textBoxes[4, 6].Text = "";
            textBoxes[4, 7].Text = "5";
            textBoxes[4, 8].Text = "";

            textBoxes[5, 0].Text = "8";
            textBoxes[5, 1].Text = "";
            textBoxes[5, 2].Text = "";
            textBoxes[5, 3].Text = "";
            textBoxes[5, 4].Text = "";
            textBoxes[5, 5].Text = "";
            textBoxes[5, 6].Text = "";
            textBoxes[5, 7].Text = "";
            textBoxes[5, 8].Text = "";

            textBoxes[6, 0].Text = "";
            textBoxes[6, 1].Text = "";
            textBoxes[6, 2].Text = "9";
            textBoxes[6, 3].Text = "";
            textBoxes[6, 4].Text = "";
            textBoxes[6, 5].Text = "";
            textBoxes[6, 6].Text = "";
            textBoxes[6, 7].Text = "";
            textBoxes[6, 8].Text = "";

            textBoxes[7, 0].Text = "";
            textBoxes[7, 1].Text = "";
            textBoxes[7, 2].Text = "3";
            textBoxes[7, 3].Text = "";
            textBoxes[7, 4].Text = "";
            textBoxes[7, 5].Text = "";
            textBoxes[7, 6].Text = "9";
            textBoxes[7, 7].Text = "";
            textBoxes[7, 8].Text = "";

            textBoxes[8, 0].Text = "";
            textBoxes[8, 1].Text = "";
            textBoxes[8, 2].Text = "";
            textBoxes[8, 3].Text = "";
            textBoxes[8, 4].Text = "";
            textBoxes[8, 5].Text = "";
            textBoxes[8, 6].Text = "";
            textBoxes[8, 7].Text = "";
            textBoxes[8, 8].Text = "";
            timerTex.Visibility = Visibility.Visible;

            iniciar();
        }






        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {
            timerTex.Visibility = Visibility.Hidden;
            stopwatch.Stop();
            timer.Stop();

            // Llamar a la función SolveSudoku
            TextBox[,] board = textBoxes; // Obtener el tablero de sudoku
            bool solved = SolveSudoku(board); // Resolver el sudoku
            if (solved)
            {

                MessageBox.Show("tablero completado"); // Mostrar el tablero resuelto

            }
            else
            {
                MessageBox.Show("No se pudo resolver el Sudoku");
            }
        }

        private void CreateTextBoxMatrix()
        {
            int numRows = 9;
            int numCols = 9;
            textBoxes = new TextBox[numRows, numCols];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    TextBox textBox = new TextBox
                    {
                        Name = "matriz" + i.ToString() + j.ToString(),
                        Width = 55,
                        Height = 55,
                        FontSize = 40,
                        TextAlignment = TextAlignment.Center,
                        VerticalContentAlignment = VerticalAlignment.Center,
                        MaxLength = 1,
                        Margin = new Thickness(2)

                    };


                    /*textBox.GotFocus += textBox_GotFocus;
                    textBox.LostFocus += textBox_LostFocus;*/
                    textBox.TextChanged += textBox_Change;

                    textBoxes[i, j] = textBox;


                    Grid.SetRow(textBox, i);
                    Grid.SetColumn(textBox, j);
                    SudokuGrid.Children.Add(textBox);

                }
            }

            for (int i = 0; i < numRows; i++)
            {
                SudokuGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int j = 0; j < numCols; j++)
            {
                SudokuGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {


            TextBox t = sender as TextBox;

            int col = int.Parse(t.Name.Substring(7, 1));
            int fil = int.Parse(t.Name.Substring(6, 1));


            for (int k = 0; k < 9; k++)
            {
                textBoxes[fil, k].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#850842"));
                textBoxes[k, col].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#850842"));
                textBoxes[k, col].Foreground = Brushes.White;
                textBoxes[fil, k].Foreground = Brushes.White;
            }


        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox t = sender as TextBox;

            int col = int.Parse(t.Name.Substring(7, 1));
            int fil = int.Parse(t.Name.Substring(6, 1));


            for (int k = 0; k < 9; k++)
            {
                textBoxes[fil, k].Background = Brushes.Transparent;
                textBoxes[k, col].Background = Brushes.Transparent;
                textBoxes[k, col].Foreground = Brushes.Black;
                textBoxes[fil, k].Foreground = Brushes.Black;


            }
        }

        private void textBox_Change(object sender, TextChangedEventArgs e)
        {
            TextBox t = sender as TextBox;
            int col = int.Parse(t.Name.Substring(7, 1));
            int fil = int.Parse(t.Name.Substring(6, 1));
            string num = t.Text;


            // MessageBox.Show(t.Name);

            if (MovimientoValido2(textBoxes, fil, col, num))
            {
                textBoxes[fil, col].Background = Brushes.White;
                textBoxes[fil, col].Foreground = Brushes.Black;
            }
            else
            {
                textBoxes[fil, col].Background = Brushes.DarkRed;
                textBoxes[fil, col].Foreground = Brushes.White;

                contador++;
                lbl_fallos.Content = contador.ToString();
                if (contador == 3)
                {
                    MessageBox.Show("Tercermundista");
                }
            }

        }


        private bool MovimientoValido(TextBox[,] board, int row, int col, string num)
        {

            // Verificar fila y columna
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i].Text == num || board[i, col].Text == num)
                {
                    return false;
                }
            }

            // Verificar cuadrante 3x3
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;

            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (board[i, j].Text == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool MovimientoValido2(TextBox[,] board, int row, int col, string num)
        {
            int repetidosGlobal = 0;

            // Verificar fila y columna
            for (int i = 0; i < 9; i++)
            {
                if (num != "")
                {
                    if (board[row, i].Text == num || board[i, col].Text == num)
                    {
                        repetidosGlobal++;
                    }
                }
            }


            // Verificar cuadrante 3x3
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            int repetidosCuadrante = 0;

            for (int i = boxRow; i < boxRow + 3; i++)
            {
                for (int j = boxCol; j < boxCol + 3; j++)
                {
                    if (board[i, j].Text == num && num != "")
                    {
                        repetidosCuadrante++;
                    }
                }
            }

            if (repetidosCuadrante >= 2 || repetidosGlobal >= 3)
            {
                return false;
            }

            return true;
        }

        private bool SolveSudoku(TextBox[,] board)
        {
            int row = 0;
            int col = 0;
            bool isEmpty = true;

            // Buscar la próxima Fcelda vacía
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    if (board[i, j].Text == "")
                    {

                        row = i;
                        col = j;
                        isEmpty = false;
                        break;

                    }
                }

                if (!isEmpty)
                {
                    break;
                }
            }

            // Si no hay celdas vacías, el tablero está resuelto
            if (isEmpty)
            {
                return true;
            }

            // Intentar valores del 1 al 9 para la celda vacía
            for (int num = 1; num <= 9; num++)
            {
                if (MovimientoValido(board, row, col, num.ToString()))
                {
                    board[row, col].Text = num.ToString();


                    // Recursivamente intentar resolver el tablero con la nueva celda
                    if (SolveSudoku(board))
                    {
                        return true;
                    }
                    else
                    {
                        board[row, col].Foreground = Brushes.Black;
                        // Si no se puede resolver, restaurar el valor anterior y probar otro
                        board[row, col].Text = "";
                    }
                }
            }
            // Si no se pudo encontrar ninguna solución, volver atrás
            return false;

        }

        private void SolveButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Partida_Click(object sender, RoutedEventArgs e)
        {
            if (dificultad.SelectedIndex == 0)
            {


                int op = new Random().Next(1, 4);
                switch (op)
                {
                    case 1: limpiarsodoku(); nivelfacil(); break;
                    case 2: limpiarsodoku(); nivelfacil1(); break;
                    case 3: limpiarsodoku(); nivelfacil2(); break;
                    default: break;

                }
            }

            if (dificultad.SelectedIndex == 1)
            {
                int op = new Random().Next(1, 4);
                switch (op)
                {
                    case 1: limpiarsodoku(); nivelmedio(); break;
                    case 2: limpiarsodoku(); nivelmedio1(); break;
                    case 3: limpiarsodoku(); nivelmedio2(); break;
                    default: break;

                }
            }
            if (dificultad.SelectedIndex == 2)
            {

                int op = new Random().Next(1, 4);
                switch (op)
                {
                    case 1: limpiarsodoku(); niveldificil(); break;
                    case 2: limpiarsodoku(); niveldificil1(); break;
                    case 3: limpiarsodoku(); niveldificil2(); break;
                    default: break;

                }


            }
        }

        private void limpiar_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    /*textBoxes[i, j].Background= Brushes.White;
                    textBoxes[i, j].Foreground = Brushes.Black;*/
                    textBoxes[i, j].Text = "";

                }
            }

        }

        private void limpiarsodoku()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    /*textBoxes[i, j].Background= Brushes.White;
                    textBoxes[i, j].Foreground = Brushes.Black;*/
                    textBoxes[i, j].Text = "";

                }
            }
        }

        private void limpiar_Click_1(object sender, RoutedEventArgs e)
        {
            timerTex.Visibility = Visibility.Hidden;
            limpiarsodoku();
            stopwatch.Stop();
            timer.Stop();

        }
    }
}

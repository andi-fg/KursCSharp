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
using System.Windows.Threading;

namespace testWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private bool rechts = true;
        private bool unten = true;
        private int zaehler = 0;
        private int zaehlerDaneben = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += BewegeBall;
        }

        private void BewegeBall(object sender, EventArgs e)
        {
            var x = Canvas.GetLeft(Ball);
            if(rechts)
            {
                Canvas.SetLeft(Ball, x + 5);
            }
            else
            {
                Canvas.SetLeft(Ball, x - 5);
            }
            if(x>= Spielplatz.ActualWidth - Ball.ActualWidth)
            {
                rechts = false;
            }else if (x <= 0){
                rechts = true;
            }

            var y = Canvas.GetTop(Ball);
            if (unten)
            {
                Canvas.SetTop(Ball, y + 5);
            }
            else
            {
                Canvas.SetTop(Ball, y - 5);
            }
            if (y >= Spielplatz.ActualHeight - Ball.ActualHeight)
            {
                unten = false;
            }
            else if (y <= 0)
            {
                unten = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
            }
            else
            {
                zaehler = 0;
                klicksLbl.Content = $"Anzahl Klicks auf Ball: {zaehler}";
                zaehlerDaneben = 0;
                danebenLbl.Content = $"Klicks daneben: {zaehlerDaneben}";
                timer.Start();
            }
            /*var mitteX = Spielplatz.ActualWidth / 2;
            var mitteY = Spielplatz.ActualHeight / 2;

            Canvas.SetLeft(Ball, mitteX);
            Canvas.SetTop(Ball, mitteY);*/

        }

        private void Ball_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (timer.IsEnabled)
            {
                zaehler++;
                zaehlerDaneben--;
                klicksLbl.Content = $"Anzahl Klicks auf Ball: {zaehler}";
                
            }
        }

        private void Ball_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.G)
            {
                Ball.Fill = Brushes.Green;
            }else if (!timer.IsEnabled)
            {
                if (e.Key == Key.Up)
                {
                    var y = Canvas.GetTop(Ball);
                    if (y - 5 >= 0)
                    {
                        Canvas.SetTop(Ball, y - 5);
                    }
                }
                else if (e.Key == Key.Down)
                {
                    var y = Canvas.GetTop(Ball);
                    if (y + 5 <= Spielplatz.ActualHeight - Ball.ActualHeight)
                    {
                        Canvas.SetTop(Ball, y + 5);
                    }
                }
                else if (e.Key == Key.Left)
                {
                    var x = Canvas.GetLeft(Ball);
                    if (x - 5 >= 0)
                    {
                        Canvas.SetLeft(Ball, x - 5);
                    }
                }
                else if (e.Key == Key.Right)
                {
                    var x = Canvas.GetLeft(Ball);
                    if (x + 5 <= Spielplatz.ActualWidth - Ball.ActualWidth)
                    {
                        Canvas.SetLeft(Ball, x + 5);
                    }
                }
            }
            
        }

        private void Spielplatz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (timer.IsEnabled)
            {
                zaehlerDaneben++;
                danebenLbl.Content = $"Klicks daneben: {zaehlerDaneben}";
                rechneDurchschnitt();
            }
        }

        private void rechneDurchschnitt()
        {
            if(zaehler == 0)
            {
                durchschnittLbl.Content = "0%";
            } else if(zaehlerDaneben == 0)
            {
                durchschnittLbl.Content = "100%";
            } else
            {
                var alle = zaehler + zaehlerDaneben;
                var d = (double)zaehler / (double)alle * 100;

              
                durchschnittLbl.Content = $"{Math.Round(d,2)}%";
            }
        }
    }
}

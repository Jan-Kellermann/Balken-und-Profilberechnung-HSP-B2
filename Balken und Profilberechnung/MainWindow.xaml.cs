using Microsoft.Win32;
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


namespace Balken_und_Profilberechnung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void SelectionChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {

            string Auswahl = ((TreeViewItem)e.NewValue).Name.ToString();

            if (Auswahl == "itmRechteck") 
            {
               
                lblBreiteb.Visibility = Visibility.Visible;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Visible;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;

                
                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;


                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;

                imFigur.Source = new BitmapImage(new Uri("Rechteck.PNG", UriKind.Relative));

            }

            if (Auswahl == "itmRund")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Hidden;


                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;


                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;

                imFigur.Source = new BitmapImage(new Uri("Kreis.PNG", UriKind.Relative));


            }

            if (Auswahl == "itmVierkantrohr")
            {
                lblBreiteb.Visibility = Visibility.Visible;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Visible;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;


                lblBreiteB.Visibility = Visibility.Visible;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Visible;

                lblHöheH.Visibility = Visibility.Visible;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Visible;


                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;

                imFigur.Source = new BitmapImage(new Uri("Kasten.PNG", UriKind.Relative));
            }

            if (Auswahl == "itmRohr")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;


                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;


                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;

                imFigur.Source = new BitmapImage(new Uri("Rohr.PNG", UriKind.Relative));

            }

            if (Auswahl == "itmT_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;


                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;


                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;

                imFigur.Source = new BitmapImage(new Uri("T-Profil.PNG", UriKind.Relative));

            }


            if (Auswahl == "itmI_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;


                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;


                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;

                imFigur.Source = new BitmapImage(new Uri("I-Profil.PNG", UriKind.Relative));
            }






        }


        private void Txb_höhe_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double zahl;

            if (Double.TryParse(tb.Text, out zahl))
            {
                tb.Background = Brushes.Green;
                tb.Foreground = Brushes.Black;
                // alles gut
            }
            else
            {
                MessageBox.Show("Es dürfen nur positive Zahlen eingegeben werden!", "Fehler");
                // Fehler
            }
        }

        private void Txb_höhe_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Foreground = Brushes.Black;
        }

        private void txb_höhe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      



        private void btnEnde_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgAntwort;
            msgAntwort = MessageBox.Show("Wollen Sie wirklich das Programm beenden?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (msgAntwort == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }

        
    }



}




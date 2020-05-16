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






        private void btnRechne_Click(object sender, RoutedEventArgs e)
        {

            //Testfall Rohr
            string bezeichnung_case;
            bezeichnung_case = "itmRohr";



            switch (bezeichnung_case)
            {

                case "itmRechteck": //Rechteck
                    break;


                case "itmT_Profil":
                    break;


                case "itmVierkantrohr":
                    break;


                case "itmRund":
                    break;


                case "itmRohr": //Rohr

                    string sDurchmesserEingabeAussen;
                    string sDurchmesserEingabeInnen;
                    string sLängeEingabeRohr;


                    double dDurchmesserAussen;
                    double dDurchmesserInnen;
                    double dLängeRohr;

                    double dVolumen;
                    double dFlaeche;
                    double dMasse;
                    double dPreis;
                    double dSchwerpunktX;
                    double dSchwerpunktY;
                    double dSchwerpunktZ;
                    double dIX;
                    double dIY;





                    //Übergabe der Eingabevariablen in String Variablen
                    sDurchmesserEingabeAussen = txt3.Text;
                    sDurchmesserEingabeInnen = txt2.Text;
                    sLängeEingabeRohr = txtLänge.Text;


                    //Übergabe der String Variablen nach Double
                    dDurchmesserInnen = Convert.ToDouble(sDurchmesserEingabeInnen);
                    dDurchmesserAussen = Convert.ToDouble(sDurchmesserEingabeAussen);
                    dLängeRohr = Convert.ToDouble(sLängeEingabeRohr);

                    //Innendurchmesser kleiner?
                    if (dDurchmesserInnen > dDurchmesserAussen)
                    {
                        MessageBox.Show("Der Innendurchmesser muss kleiner sein als der Außendurchmesser");
                    }

                    //Durchmesser korrekt
                    else
                    {
                        // Berechnung in Double Variablen
                        dFlaeche = Kreisfläche(dDurchmesserAussen) - Kreisfläche(dDurchmesserInnen);
                        dVolumen = dFlaeche * dLängeRohr;
                        dMasse = 1;
                        dPreis = 1;
                        dSchwerpunktX = dDurchmesserAussen / 2;
                        dSchwerpunktY = dDurchmesserAussen / 2;
                        dSchwerpunktZ = dLängeRohr / 2;
                        dIX = IRohr(dDurchmesserAussen, dDurchmesserInnen);
                        dIY = IRohr(dDurchmesserAussen, dDurchmesserInnen);


                        // Übergabe Double in String Variablen
                        txtVolumen.Text = Convert.ToString(dVolumen);
                        txtFlaeche.Text = Convert.ToString(dFlaeche);
                        txtMasse.Text = Convert.ToString(dMasse);
                        txtPreis.Text = Convert.ToString(dPreis);
                        txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX);
                        txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY);
                        txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ);
                        txtIX.Text = Convert.ToString(dIX);
                        txtIY.Text = Convert.ToString(dIY);
                    }
                    break;




                case "itmI_Profil":
                    break;


            }
        }

        private void btnEnde_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgAntwort;
            msgAntwort = MessageBox.Show("Wollen Sie wirklich das Programm beenden?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (msgAntwort == MessageBoxResult.Yes)
                System.Environment.Exit(0);
        }




        public static double FlaecheRechteck(double a, double b)
        {
            double flaeche;
            flaeche = a * b;
            return flaeche;
        }

        public static double SRechteck(double seitenlänge)
        {
            double schwerpunkt = seitenlänge / 2;
            return schwerpunkt;

        }

        public static double IRechteck(double a, double b)
        {
            double I = a * Math.Pow(b, 3) / 12;
            return I;
        }

        public static bool PrüfungZahl(string Eingabe)
        {
            int i = 0;
            bool result = int.TryParse(Eingabe, out i);

            return result;
        }

        public static double IKreis(double d)
        {
            double I = (Math.PI * Math.Pow(d, 4)) / 64;
            return I;
        }

        public static double Kreisfläche(double d)
        {
            double s = d / 2;
            double A = Math.PI * Math.Pow(s, 2);
            return A;
        }

        public static double IRohr(double D, double d)
        {
            double I = Math.PI * (Math.Pow(D, 4) - Math.Pow(d, 4)) / 64;
            return I;
        }


    }
}




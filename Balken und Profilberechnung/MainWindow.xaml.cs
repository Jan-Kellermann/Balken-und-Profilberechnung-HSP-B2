using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
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

        public string Auswahl;
        public string Material;
        public string Einheit;
        public double dDichte;
        public double dGewicht;
        public double dFaktor;
        public double dPreis;


        public void SelectionChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {

            Auswahl = ((TreeViewItem)e.NewValue).Name.ToString();
           //Material = ((ComboBoxItem)e.NewValue).Content.ToString();            
           // Einheit = ((ComboBoxItem)e.NewValue).Name == "cboEinheit".ToString();


            if (Auswahl == "itmRechteck")
            {

                lblBreiteb.Visibility = Visibility.Visible;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = " ";

                lblHöheh.Visibility = Visibility.Visible;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = " ";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = " ";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = " ";

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("Rechteck.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";




            }

            if (Auswahl == "itmRund")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = " ";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Hidden;
                txt3.Text = " ";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = " ";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = " ";

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("Kreis.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";





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

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("Kasten.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";




            }

            if (Auswahl == "itmRohr")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = " ";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = " ";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = " ";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = " ";

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("Rohr.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";




            }

            if (Auswahl == "itmT_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = " ";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = " ";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt5.Text = " ";

                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt6.Text = " ";

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("T-Profil.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";


            }


            if (Auswahl == "itmI_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = " ";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = " ";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt5.Text = " ";

                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt6.Text = " ";

                lblMaterial.Visibility = Visibility.Visible;
                cboMaterial.Visibility = Visibility.Visible;
                lblLänge.Visibility = Visibility.Visible;
                txtLänge.Visibility = Visibility.Visible;
                lblEinheit.Visibility = Visibility.Visible;
                cboEinheit.Visibility = Visibility.Visible;

                imTitel.Visibility = Visibility.Hidden;
                imFigur.Visibility = Visibility.Visible;
                imFigur.Source = new BitmapImage(new Uri("I-Profil.PNG", UriKind.Relative));

                txtVolumen.Text = " ";
                txtFlaeche.Text = " ";
                txtMasse.Text = " ";
                txtPreis.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtSchwerpunktX.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";


            }

            if (Auswahl == "itmEVoll")
            {


                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Balken.jpg", UriKind.Relative));

            }

            if (Auswahl == "itmESonstige")
            {

                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Profile.jpg", UriKind.Relative));


            }
            if (Auswahl == "itmERund")
            {

                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Rohr.jpg", UriKind.Relative));


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





            switch (Auswahl)
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

                        //Masse und Preis berechnen

                        //                < !--Textboxen zur Eingabe-->
                        //< Label x: Name = "lblMaterial" Content = "Material:" HorizontalAlignment = "Left" Margin = "158,56,0,0" VerticalAlignment = "Top" Height = "23" Visibility = "Hidden" />             

                        //              < ComboBox x: Name = "cboMaterial" HorizontalAlignment = "Left" Height = "23" Margin = "222,56,0,0" VerticalAlignment = "Top" Width = "120" Visibility = "Hidden" >                             
                        //                                < ComboBoxItem > Holz </ ComboBoxItem >                             
                        //                                < ComboBoxItem > Stahl </ ComboBoxItem >                             
                        //                                < ComboBoxItem > Aluminium </ ComboBoxItem >                             
                        //                                < ComboBoxItem > Kunststoff </ ComboBoxItem >                             
                        //                            </ ComboBox >                             

                        //                            < Label x: Name = "lblEinheit" Content = "Einheit:" HorizontalAlignment = "Left" Margin = "158,96,0,0" VerticalAlignment = "Top" Height = "31" Visibility = "Hidden" />                                           

                        //                                          < ComboBox x: Name = "cboEinheit" HorizontalAlignment = "Left" Height = "23" Margin = "222,96,0,0" VerticalAlignment = "Top" Width = "120" Visibility = "Hidden" >                                                         
                        //                                                            < ComboBoxItem > mm </ ComboBoxItem >                                                         
                        //                                                            < ComboBoxItem > cm </ ComboBoxItem >                                                         
                        //                                                            < ComboBoxItem > Zoll </ ComboBoxItem >                                                         
                        //                                                            < ComboBoxItem > Fuß </ ComboBoxItem >

                        //                                                        </ ComboBox >

                        string Material = cboMaterial.SelectedItem.ToString();

                        //MessageBox.Show(Material);
                        //string Pfad = "System.Windows.Controls.ComboBoxItem: ";

                        switch (Material) //legt die dichte eines Materials in kg/m³ fest und den Preis in Euro auf 1g
                        {
                            case "System.Windows.Controls.ComboBoxItem: Holz":
                                dDichte = 650;
                                dPreis = 0.001;
                                break;


                            case "System.Windows.Controls.ComboBoxItem: Stahl":
                                dDichte = 7874;
                                dPreis = 0.002;
                                break;

                            case "System.Windows.Controls.ComboBoxItem: Aluminium":
                                dDichte = 2700;
                                dPreis = 0.006;
                                break;

                            case "System.Windows.Controls.ComboBoxItem: Kunststoff":
                                dDichte = 900;
                                dPreis = 0.004;
                                break;

                        }

                        string Einheit = cboEinheit.SelectedItem.ToString();

                        //MessageBox.Show(Material);
                        //string Pfad = "System.Windows.Controls.ComboBoxItem: ";

                        switch (Einheit) //legt einen Faktor von mm in die jeweilige Einheit fest
                        {
                            case "System.Windows.Controls.ComboBoxItem: Standard in mm":
                                dFaktor = 1;
                                break;


                            case "System.Windows.Controls.ComboBoxItem: cm":
                                dFaktor = 0.1;
                                break;

                            case "System.Windows.Controls.ComboBoxItem: Zoll":
                                dFaktor = 0.039370078;
                                break;

                            case "System.Windows.Controls.ComboBoxItem: Fuß":
                                dFaktor = 0.00328083989;
                                break;

                        }



                        //MessageBox.Show(dDichte.ToString());







                        dSchwerpunktX = dDurchmesserAussen / 2;
                        dSchwerpunktY = dDurchmesserAussen / 2;
                        dSchwerpunktZ = dLängeRohr / 2;
                        dIX = IRohr(dDurchmesserAussen, dDurchmesserInnen);
                        dIY = IRohr(dDurchmesserAussen, dDurchmesserInnen);
                        dGewicht = dVolumen * dDichte;

                        // Übergabe Double in String Variablen
                        txtVolumen.Text = Convert.ToString(dVolumen);
                        txtFlaeche.Text = Convert.ToString(dFlaeche);
                        txtMasse.Text = Convert.ToString(dGewicht);
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
                System.Environment.Exit(1);
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




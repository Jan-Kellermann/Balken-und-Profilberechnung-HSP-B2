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
using CATMat;





namespace Balken_und_Profilberechnung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sBreite;
        string sHöhe;
        public double dBreite;
        public double dHöhe;
        double dBreiteb1;
        double dBreiteb2;
        double dHöheTIProfilh;
        double dBreiteITProfilB;
        double dHöheITProfilH;
        string sBreiteI;
        string sHöheI;
        string sBreiteA;
        string sHöheA;
        double dBreiteI;
        double dHöheI;
        double dBreiteA;
        double dHöheA;
        string sDurchmesserEingabe;
        double dDurchmesser;
        string sDurchmesserEingabeAussen;
        string sDurchmesserEingabeInnen;
        double dDurchmesserAussen;
        double dDurchmesserInnen;
        double dIBreiteb1;
        double dIBreiteb2;
        double dHöheIIProfilh;
        double dBreiteIIProfilB;
        double dHöheIIProfilH;
        public int MatAuswahl;


        public MainWindow()
        {
            InitializeComponent();
        }
        //Erstellung aller Globalen Variablen 
        public string sLängeEingabe;
        public double dLaenge;

        public string Auswahl;
        public string Material;
        public string Einheit;
        public string sEinheit;
        public double dDichte;
        public double dGewicht;
        public double dFaktor;

        public double dPreisProG;
        public double dPreis;
        public double dVolumen;
        public double dFlaeche;

        public int iKomma = 2;

        public double dSchwerpunktX;
        public double dSchwerpunktY;
        public double dSchwerpunktZ;
        public double dIX;
        public double dIY;

        public int Profil;

        public void SelectionChanged(object sender, RoutedPropertyChangedEventArgs<Object> e)
        {




            Auswahl = ((TreeViewItem)e.NewValue).Name.ToString();

            //Auswahl des entsprechenden Brechnungslayouts *********************************************************************************           

            if (Auswahl == "itmRechteck")
            {

                lblBreiteb.Visibility = Visibility.Visible;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Visible;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = "";

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
                txtSchwerpunktZ.Text = " ";
                txtSchwerpunktY.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;
                Profil = 1;
            }

            if (Auswahl == "itmRund")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Hidden;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = "";

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
                txtSchwerpunktY.Text = " ";
                txtSchwerpunktZ.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;

                Profil = 3;
            }

            if (Auswahl == "itmVierkantrohr")
            {
                lblBreiteb.Visibility = Visibility.Visible;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Visible;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Visible;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Visible;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Visible;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = "";

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
                txtSchwerpunktY.Text = " ";
                txtSchwerpunktZ.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;
                Profil = 2;


            }

            if (Auswahl == "itmRohr")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Hidden;
                lblDurchmesserd.Visibility = Visibility.Visible;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Hidden;
                lblDurchmesserD.Visibility = Visibility.Visible;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Hidden;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Hidden;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Hidden;
                txt6.Visibility = Visibility.Hidden;
                txt6.Text = "";

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
                txtSchwerpunktZ.Text = " ";
                txtSchwerpunktY.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;
                Profil = 4;

            }

            if (Auswahl == "itmT_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt6.Text = "";

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
                txtSchwerpunktY.Text = " ";
                txtSchwerpunktZ.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;
                Profil = 5;
            }


            if (Auswahl == "itmI_Profil")
            {
                lblBreiteb.Visibility = Visibility.Hidden;
                lblBreiteb1.Visibility = Visibility.Visible;
                lblDurchmesserd.Visibility = Visibility.Hidden;
                txt2.Visibility = Visibility.Visible;
                txt2.Text = "";

                lblHöheh.Visibility = Visibility.Hidden;
                lblBreiteb2.Visibility = Visibility.Visible;
                lblDurchmesserD.Visibility = Visibility.Hidden;
                txt3.Visibility = Visibility.Visible;
                txt3.Text = "";

                lblBreiteB.Visibility = Visibility.Hidden;
                lblHöheTIProfilh.Visibility = Visibility.Visible;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = "";

                lblHöheH.Visibility = Visibility.Hidden;
                lblBreiteITProfilB.Visibility = Visibility.Visible;
                txt5.Visibility = Visibility.Visible;
                txt5.Text = "";

                lblHöheITProfilH.Visibility = Visibility.Visible;
                txt6.Visibility = Visibility.Visible;
                txt6.Text = "";

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
                txtSchwerpunktY.Text = " ";
                txtSchwerpunktZ.Text = " ";
                txtIX.Text = " ";
                txtIY.Text = " ";

                txtLänge.Text = "";
                lblStartseite.Visibility = Visibility.Hidden;
                Profil = 6;
            }


            if (Auswahl == "itmEVoll")
            {


                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Balken.jpg", UriKind.Relative));
                lblStartseite.Visibility = Visibility.Hidden;
            }

            if (Auswahl == "itmESonstige")
            {

                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Profile.jpg", UriKind.Relative));
                lblStartseite.Visibility = Visibility.Hidden;

            }
            if (Auswahl == "itmERund")
            {

                imTitel.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Rohr.jpg", UriKind.Relative));
                lblStartseite.Visibility = Visibility.Hidden;


            }

            if (Auswahl == "itmStartseite")
            {

                imTitel.Visibility = Visibility.Visible;
                lblStartseite.Visibility = Visibility.Visible;
                imTitel.Source = new BitmapImage(new Uri("Startseite.jpg", UriKind.Relative));

            }
        }







        //Start der Berechnung***************************************************************************


        public void btnRechne_Click(object sender, RoutedEventArgs e)
        {

            //Auslesen der Combo Boxen
            
            string Material = cboMaterial.SelectedItem.ToString();

            //MessageBox.Show(Material);
            //string Pfad = "System.Windows.Controls.ComboBoxItem: ";

            switch (Material) //legt die dichte eines Materials in kg/m³ fest und den Preis in Euro auf 1g
            {
                case "System.Windows.Controls.ComboBoxItem: Holz":
                    dDichte = 650;
                    dPreisProG = 0.001;
                    MatAuswahl = 1;
                    break;

                case "System.Windows.Controls.ComboBoxItem: Stahl":
                    dDichte = 7874;
                    dPreisProG = 0.003;
                    MatAuswahl = 2;
                    break;

                case "System.Windows.Controls.ComboBoxItem: Aluminium":
                    dDichte = 2700;
                    dPreisProG = 0.0016;
                    MatAuswahl = 3;
                    break;

                case "System.Windows.Controls.ComboBoxItem: Kunststoff":
                    dDichte = 900;
                    dPreisProG = 0.0004;
                    MatAuswahl = 4;
                    break;
                case "System.Windows.Controls.ComboBoxItem: Titan":
                    dDichte = 4500;
                    dPreisProG = 0.005;
                    MatAuswahl = 5;
                    break;
            }

            string Einheit = cboEinheit.SelectedItem.ToString();


            switch (Einheit) //legt einen Faktor von mm in die jeweilige Einheit fest
            {
                case "System.Windows.Controls.ComboBoxItem: Standard in mm":
                    dFaktor = 1;
                    sEinheit = "mm";
                    break;


                case "System.Windows.Controls.ComboBoxItem: cm":
                    dFaktor = 10;
                    sEinheit = "cm";
                    break;

                case "System.Windows.Controls.ComboBoxItem: Zoll":
                    dFaktor = 25.4;
                    sEinheit = "Zoll";
                    break;

                case "System.Windows.Controls.ComboBoxItem: Fuß":
                    dFaktor = 304.8;
                    sEinheit = "Fuß";
                    break;

            }



            switch (Auswahl)
            {

                case "itmRechteck": //Rechteck
                    

                    //Übergabe der Eingabevariablen in String Variablen
                    sBreite = txt2.Text;
                    sHöhe = txt3.Text;
                    sLängeEingabe = txtLänge.Text;


                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sBreite) || string.IsNullOrEmpty(sHöhe) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }

                    else
                    {

                        if ((sBreite.Contains(" ") || sHöhe.Contains(" ") || sLängeEingabe.Contains(" ")) == true)
                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten.");
                        }
                        else
                        {

                            //Prüfung ob es Zahl ist

                            if (!Double.TryParse(sBreite, out dBreite) || !Double.TryParse(sHöhe, out dHöhe) || !Double.TryParse(sLängeEingabe, out dLaenge))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }

                            else
                            {
                                //Übergabe der String Variablen nach Double
                                dHöhe = Convert.ToDouble(sHöhe);
                                dBreite = Convert.ToDouble(sBreite);
                                dLaenge = Convert.ToDouble(sLängeEingabe);


                                if (dLaenge <= 0 || dBreite <= 0 || dHöhe <= 0)
                                {
                                    MessageBox.Show("Ihre Eingaben müssen größer null sein.");
                                }

                                else
                                {

                                    // Berechnungen in Double Variablen
                                    //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma
                                    dFlaeche = Math.Round((FlaecheRechteck(dBreite, dHöhe)) * dFaktor, 2);
                                    dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 2);
                                    dSchwerpunktX = Math.Round((dBreite / 2) * dFaktor, 2);
                                    dSchwerpunktY = Math.Round((dBreite / 2) * dFaktor, 2);
                                    dSchwerpunktZ = Math.Round((dLaenge / 2) * dFaktor, 2);
                                    dIX = Math.Round((IRechteck(dBreite, dHöhe)) * dFaktor, 2);
                                    dIY = Math.Round((IRechteck(dHöhe, dBreite)) * dFaktor, 2);
                                    dGewicht = Math.Round(dVolumen * dDichte * dFaktor / 1000000000, 4);
                                    dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);

                                    // Übergabe Double in String Variablen
                                    txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                    txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                    txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                    txtPreis.Text = Convert.ToString(dPreis) + "€";

                                    txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX) + "mm";
                                    txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                    txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                    txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                    txtIY.Text = Convert.ToString(dIY) + "mm^4";
                                }
                            }
                        }
                    }
                    break;


                case "itmT_Profil":
                    sLängeEingabe = txtLänge.Text;
                    string sBreiteb1Eingabe = txt2.Text;
                    string sBreiteb2Eingabe = txt3.Text;
                    string sHöheTIProfilhEingabe = txt4.Text;
                    string sBreiteITProfilBEingabe = txt5.Text;
                    string sHöheITProfilHEingabe = txt6.Text;


                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sBreiteb1Eingabe) || string.IsNullOrEmpty(sBreiteb2Eingabe) || string.IsNullOrEmpty(sHöheITProfilHEingabe) || string.IsNullOrEmpty(sHöheTIProfilhEingabe) || string.IsNullOrEmpty(sBreiteITProfilBEingabe) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }
                    else
                    {

                        if ((sLängeEingabe.Contains(" ") || sBreiteb1Eingabe.Contains(" ") || sBreiteb2Eingabe.Contains(" ") || sHöheTIProfilhEingabe.Contains(" ") || sBreiteITProfilBEingabe.Contains(" ") || sHöheITProfilHEingabe.Contains(" ")) == true)
                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                        }
                        else
                        {

                            //Prüfung ob es Zahl ist
                            if (!Double.TryParse(sBreiteb1Eingabe, out dBreiteb1) || (!Double.TryParse(sBreiteb2Eingabe, out dBreiteb2)) || (!Double.TryParse(sHöheITProfilHEingabe, out dHöheITProfilH)) || (!Double.TryParse(sBreiteITProfilBEingabe, out dBreiteITProfilB)) || (!Double.TryParse(sHöheTIProfilhEingabe, out dHöheTIProfilh)) || (!Double.TryParse(sLängeEingabe, out dLaenge)))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }

                            else
                            {

                                dLaenge = Convert.ToDouble(sLängeEingabe);
                                dBreiteb1 = Convert.ToDouble(sBreiteb1Eingabe);
                                dBreiteb2 = Convert.ToDouble(sBreiteb2Eingabe);
                                dHöheTIProfilh = Convert.ToDouble(sHöheTIProfilhEingabe);
                                dBreiteITProfilB = Convert.ToDouble(sBreiteITProfilBEingabe);
                                dHöheITProfilH = Convert.ToDouble(sHöheITProfilHEingabe);

                                if (dLaenge <= 0 || dBreiteb1 <= 0 || dBreiteb2 <= 0 || dHöheTIProfilh <= 0 || dBreiteITProfilB <= 0 || dHöheITProfilH <= 0)
                                {
                                    MessageBox.Show("Ihre Eingaben müssen größer null sein.");
                                }

                                else
                                {
                                    if (dHöheTIProfilh > dHöheITProfilH)
                                    {
                                        MessageBox.Show("Ihre Eingegebene Gesamthöhe H muss größer als Höhe h sein.");
                                    }

                                    else
                                    {
                                        double dRechteck1Fläche = FlaecheRechteck(dBreiteITProfilB, dHöheITProfilH);                                                                 //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                                        double dRechteck2Fläche = FlaecheRechteck(dBreiteb1, dHöheTIProfilh);                                                          //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                                        double dRechteck3Fläche = FlaecheRechteck(dBreiteb2, dHöheTIProfilh);

                                        double dhErsatz = dHöheITProfilH - dHöheTIProfilh;
                                        double dbErsatz = dBreiteb1 + dBreiteb2 + dBreiteITProfilB;


                                        dFlaeche = Math.Round((dRechteck1Fläche + dRechteck2Fläche + dRechteck3Fläche) * dFaktor, 4);                                                                   //Flächenberechnung der T-Träger wird aus zwei Rechtecken zusammengesetzt die über das Unterprogramm Rechteck() aus der Balkenberechnung
                                        dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 4);                                                                               // Volumen wird durch die bereits berechnete Fläche und die Trägerlänge berechnet
                                        dSchwerpunktX = Math.Round(((dRechteck1Fläche * SRechteck(dBreiteITProfilB) + dRechteck2Fläche * SRechteck(dBreiteb1) + dRechteck3Fläche * SRechteck(dBreiteb2)) / dFlaeche) * dFaktor, 2);     //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                                        dSchwerpunktY = Math.Round(((dRechteck1Fläche * SRechteck(dHöheITProfilH) + dRechteck2Fläche * SRechteck(dHöheTIProfilh) + dRechteck3Fläche * SRechteck(dHöheTIProfilh)) / dFlaeche) * dFaktor, 2);    //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                                        dSchwerpunktZ = Math.Round((dLaenge / 2) * dFaktor, 2);                                                                               //Der Schwerpunkt in Balkenlänge befindet sich mittig
                                        dIY = Math.Round((IRechteck(dbErsatz, dHöheITProfilH) + IRechteck(dBreiteITProfilB, dhErsatz)) * dFaktor * dFaktor * dFaktor * dFaktor / 12, 2);                                  //Berechnung des Flächenträgheitsmomentes um die Y Achse
                                        dIX = Math.Round((IRechteck(dhErsatz, dBreiteITProfilB) + IRechteck(dHöheITProfilH, dbErsatz)) * dFaktor * dFaktor * dFaktor * dFaktor / 12, 2);                                          //Berechnung des Flächenträgheitsmomentes um die X Achse (Steiner Anteil konnte ich noch nicht implementieren) 
                                        dGewicht = Math.Round((dVolumen / 1000000000) * dDichte, 4);
                                        dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);

                                        //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma

                                        txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                        txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                        txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                        txtPreis.Text = Convert.ToString(dPreis) + "€";
                                        txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX) + "mm";
                                        txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                        txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                        txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                        txtIY.Text = Convert.ToString(dIY) + "mm^4";
                                    }
                                }
                            }
                        }
                    }


                    break;


                case "itmVierkantrohr":
                    

                    //Übergabe der Eingabevariablen in String Variablen
                    sBreiteI = txt4.Text;
                    sHöheI = txt5.Text;
                    sBreiteA = txt2.Text;
                    sHöheA = txt3.Text;
                    sLängeEingabe = txtLänge.Text;

                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sBreiteI) || string.IsNullOrEmpty(sHöheI) || string.IsNullOrEmpty(sBreiteA) || string.IsNullOrEmpty(sHöheA) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }
                    else
                    {

                        if ((sBreiteI.Contains(" ") || sHöheI.Contains(" ") || sBreiteA.Contains(" ") || sHöheA.Contains(" ") || sLängeEingabe.Contains(" ")) == true)
                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                        }
                        else
                        {

                            //Prüfung ob es Zahl ist
                            if (!Double.TryParse(sBreiteI, out dBreiteI) || (!Double.TryParse(sHöheI, out dHöheI)) || (!Double.TryParse(sBreiteA, out dBreiteA)) || (!Double.TryParse(sHöheA, out dHöheA)) || (!Double.TryParse(sLängeEingabe, out dLaenge)))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }

                            else
                            {

                                //Übergabe der String Variablen nach Double
                                dHöheI = Convert.ToDouble(sHöheI);
                                dBreiteI = Convert.ToDouble(sBreiteI);
                                dHöheA = Convert.ToDouble(sHöheA);
                                dBreiteA = Convert.ToDouble(sBreiteA);
                                dLaenge = Convert.ToDouble(sLängeEingabe);

                                if (dHöheA >= dHöheI)
                                {
                                    MessageBox.Show("Die äußere Höhe muss größer als die Innere sein");
                                }

                                if (dBreiteA >= dBreiteI)
                                {
                                    MessageBox.Show("Die äußere Breite muss größer als die Innere sein");
                                }

                                if (dLaenge <= 0 || dBreiteI <= 0 || dHöheI <= 0 || dBreiteA <= 0 || dHöheA <= 0)
                                {
                                    MessageBox.Show("Ihre Eingaben müssen größer null sein.");
                                }

                                else
                                {

                                    // Berechnungen in Double Variablen
                                    //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma
                                    dFlaeche = Math.Round(FlaecheRechteck(dBreiteA - dBreiteI, dHöheA - dHöheI) * dFaktor, 2);
                                    dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 2);
                                    dSchwerpunktX = Math.Round((dBreiteA - dBreiteI / 2) * dFaktor, 2);
                                    dSchwerpunktY = Math.Round((dBreiteA - dBreiteI / 2) * dFaktor, 2);
                                    dSchwerpunktZ = Math.Round((dLaenge / 2) * dFaktor, 2);
                                    dIX = Math.Round((IRechteck(dBreiteA - dBreiteI, dHöheA - dHöheI)) * dFaktor, 2);
                                    dIY = Math.Round((IRechteck(dHöheA - dHöheI, dBreiteA - dBreiteI)) * dFaktor, 2);
                                    dGewicht = Math.Round(dVolumen / 1000000000 * dDichte * dFaktor, 4);
                                    dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);

                                    // Übergabe Double in String Variablen
                                    txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                    txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                    txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                    txtPreis.Text = Convert.ToString(dPreis) + "€";

                                    txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX) + "mm";
                                    txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                    txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                    txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                    txtIY.Text = Convert.ToString(dIY) + "mm^4";
                                }
                            }
                        }
                    }

                    break;


                case "itmRund":


                    //Übergabe der Eingabevariablen in String Variablen
                    sDurchmesserEingabe = txt2.Text;

                    sLängeEingabe = txtLänge.Text;

                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sDurchmesserEingabe) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }
                    else
                    {
                        if ((sDurchmesserEingabe.Contains(" ") || sLängeEingabe.Contains(" ")) == true)
                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                        }
                        else
                        {
                            //Prüfung ob es Zahl ist
                            if (!Double.TryParse(sDurchmesserEingabe, out dDurchmesser) || (!Double.TryParse(sLängeEingabe, out dLaenge)))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }

                            else
                            {

                                //Übergabe der String Variablen nach Double
                                dDurchmesser = Convert.ToDouble(sDurchmesserEingabe);
                                dLaenge = Convert.ToDouble(sLängeEingabe);


                                // Berechnung in Double Variablen
                                //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma
                                dFlaeche = Math.Round(Kreisfläche(dDurchmesser * dFaktor), 2);
                                dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 2);
                                this.dSchwerpunktX = Math.Round(dDurchmesser / 2 * dFaktor, 2);
                                dSchwerpunktY = Math.Round(dDurchmesser / 2 * dFaktor, 2);
                                dSchwerpunktZ = Math.Round(dLaenge / 2 * dFaktor, 2);
                                dIX = Math.Round(IKreis(dDurchmesser * dFaktor), 2);
                                dIY = Math.Round(IKreis(dDurchmesser * dFaktor), 2);
                                dGewicht = Math.Round((dVolumen / 1000000000) * dDichte * dFaktor, 4);
                                dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);

                                // Übergabe Double in String Variablen
                                txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                txtPreis.Text = Convert.ToString(dPreisProG) + "€";
                                txtSchwerpunktX.Text = Convert.ToString(this.dSchwerpunktX) + "mm";
                                txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                txtIY.Text = Convert.ToString(dIY) + "mm^4";

                            }
                        }
                    }
            

                    break;


                case "itmRohr": //Rohr


                    //Übergabe der Eingabevariablen in String Variablen
                    sDurchmesserEingabeAussen = txt3.Text;
                    sDurchmesserEingabeInnen = txt2.Text;
                    sLängeEingabe = txtLänge.Text;

                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sDurchmesserEingabeAussen) || string.IsNullOrEmpty(sDurchmesserEingabeInnen) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }
                    else
                    {
                        if ((sDurchmesserEingabeAussen.Contains(" ") || sDurchmesserEingabeInnen.Contains(" ") || sLängeEingabe.Contains(" ")) == true)
                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                        }
                        else
                        {
                            //Prüfung ob es Zahl ist
                            if (!Double.TryParse(sDurchmesserEingabeAussen, out dDurchmesserAussen) || (!Double.TryParse(sDurchmesserEingabeInnen, out dDurchmesserInnen)) || (!Double.TryParse(sLängeEingabe, out dLaenge)))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }


                            else
                            {

                                //Übergabe der String Variablen nach Double
                                dDurchmesserInnen = Convert.ToDouble(sDurchmesserEingabeInnen);
                                dDurchmesserAussen = Convert.ToDouble(sDurchmesserEingabeAussen);
                                dLaenge = Convert.ToDouble(sLängeEingabe);


                                if (dDurchmesserInnen > dDurchmesserAussen)
                                {
                                    MessageBox.Show("Der Innendurchmesser muss kleiner sein als der Außendurchmesser");
                                }

                                if (dLaenge <= 0 || dDurchmesserAussen <= 0 || dDurchmesserInnen <= 0)
                                {
                                    MessageBox.Show("Ihre Eingaben müssen größer null sein.");
                                }

                                else
                                {
                                    // Berechnung in Double Variablen
                                    //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma
                                    dFlaeche = Math.Round(Kreisfläche(dDurchmesserAussen) - Kreisfläche(dDurchmesserInnen), 2);
                                    dVolumen = Math.Round(dFlaeche * dLaenge, 2);
                                    this.dSchwerpunktX = Math.Round(dDurchmesserAussen / 2, 2);
                                    dSchwerpunktY = Math.Round(dDurchmesserAussen / 2, 2);
                                    dSchwerpunktZ = Math.Round(dLaenge / 2, 2);
                                    dIX = Math.Round(IRohr(dDurchmesserAussen, dDurchmesserInnen), 2);
                                    dIY = Math.Round(IRohr(dDurchmesserAussen, dDurchmesserInnen), 2);
                                    dGewicht = Math.Round(dVolumen / 1000000000 * dDichte * dFaktor, 4);
                                    dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);
                                    // Übergabe Double in String Variablen
                                    txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                    txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                    txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                    txtPreis.Text = Convert.ToString(dPreisProG) + "€";
                                    txtSchwerpunktX.Text = Convert.ToString(this.dSchwerpunktX) + "mm";
                                    txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                    txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                    txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                    txtIY.Text = Convert.ToString(dIY) + "mm^4";

                                }
                            }
                        }
                    }

                    break;



                case "itmI_Profil":
                    sLängeEingabe = txtLänge.Text;
                    string sIBreiteb1Eingabe = txt2.Text;
                    string sIBreiteb2Eingabe = txt3.Text;
                    string sHöheIIProfilhEingabe = txt4.Text;
                    string sBreiteIIProfilBEingabe = txt5.Text;
                    string sHöheIIProfilHEingabe = txt6.Text;

                    //Messagebox wenn Feld ist leer
                    if (string.IsNullOrEmpty(sIBreiteb1Eingabe) || string.IsNullOrEmpty(sIBreiteb2Eingabe) || string.IsNullOrEmpty(sHöheIIProfilHEingabe) || string.IsNullOrEmpty(sHöheIIProfilhEingabe) || string.IsNullOrEmpty(sBreiteIIProfilBEingabe) || string.IsNullOrEmpty(sLängeEingabe))
                    {
                        MessageBox.Show("Eingabe darf nicht null sein und jedes Feld muss ausgefüllt sein.");
                    }
                    else
                    {

                        if ((sLängeEingabe.Contains(" ") || sIBreiteb1Eingabe.Contains(" ") || sIBreiteb2Eingabe.Contains(" ") || sHöheIIProfilhEingabe.Contains(" ") || sBreiteIIProfilBEingabe.Contains(" ") || sHöheIIProfilHEingabe.Contains(" ")) == true)

                        {
                            MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                        }
                        else
                        {
                            //Prüfung ob es Zahl ist
                            if (!Double.TryParse(sIBreiteb1Eingabe, out dBreiteb1) || (!Double.TryParse(sIBreiteb2Eingabe, out dBreiteb2)) || (!Double.TryParse(sHöheIIProfilHEingabe, out dHöheITProfilH)) || (!Double.TryParse(sBreiteIIProfilBEingabe, out dBreiteITProfilB)) || (!Double.TryParse(sHöheIIProfilhEingabe, out dHöheTIProfilh)) || (!Double.TryParse(sLängeEingabe, out dLaenge)))
                            {
                                MessageBox.Show("Eingabe muss eine Zahl sein.");
                            }


                            else
                            {
                                dLaenge = Convert.ToDouble(sLängeEingabe);
                                dIBreiteb1 = Convert.ToDouble(sIBreiteb1Eingabe);
                                dIBreiteb2 = Convert.ToDouble(sIBreiteb2Eingabe);
                                dHöheIIProfilh = Convert.ToDouble(sHöheIIProfilhEingabe);
                                dBreiteIIProfilB = Convert.ToDouble(sBreiteIIProfilBEingabe);
                                dHöheIIProfilH = Convert.ToDouble(sHöheIIProfilHEingabe);

                                if (dLaenge <= 0 || dIBreiteb1 <= 0 || dIBreiteb2 <= 0 || dHöheIIProfilh <= 0 || dBreiteIIProfilB <= 0 || dHöheIIProfilH <= 0)
                                {
                                    MessageBox.Show("Ihre Eingaben müssen größer null sein.");
                                }
                                if (dHöheIIProfilh > dHöheIIProfilH)
                                {
                                    MessageBox.Show("Ihre Eingegebene Gesamthöhe H muss größer als Höhe h sein.");
                                }

                                if (dIBreiteb1 >= dBreiteIIProfilB/2)
                                {
                                    MessageBox.Show("Die Breite b1 muss kleiner als B/2 sein");
                                }

                                if (dIBreiteb2 >= dBreiteIIProfilB / 2)
                                {
                                    MessageBox.Show("Die Breite b2 muss kleiner als B/2 sein");
                                }


                                else
                                {
                                    double dRechteck1Fläche = FlaecheRechteck(dBreiteIIProfilB, dHöheIIProfilH);                                                                                                                    //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                                    double dRechteck2Fläche = FlaecheRechteck(dIBreiteb1, dHöheIIProfilh);                                                                                                                          //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                                    double dRechteck3Fläche = FlaecheRechteck(dIBreiteb2, dHöheIIProfilh);

                                    double dhErsatz = dHöheIIProfilH - dHöheIIProfilh;
                                    double dbErsatz = dIBreiteb1 + dIBreiteb2 + dBreiteIIProfilB;


                                    dFlaeche = Math.Round((dRechteck1Fläche + dRechteck2Fläche + dRechteck3Fläche) * dFaktor, 4);                                                                                                   //Flächenberechnung der I-Träger wird aus zwei Rechtecken zusammengesetzt die über das Unterprogramm Rechteck() aus der Balkenberechnung
                                    dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 4);                                                                                                                                         //Volumen wird durch die bereits berechnete Fläche und die Trägerlänge berechnet
                                    dSchwerpunktX = Math.Round(((dRechteck1Fläche * SRechteck(dBreiteIIProfilB) + dRechteck2Fläche * SRechteck(dIBreiteb1) + dRechteck3Fläche * SRechteck(dIBreiteb2)) / dFlaeche) * dFaktor, 2);   //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                                    dSchwerpunktY = Math.Round(-1 * (((dRechteck1Fläche * SRechteck(dHöheIIProfilH) + dRechteck2Fläche * SRechteck(dHöheIIProfilh) + dRechteck3Fläche * SRechteck(dHöheIIProfilh)) / dFlaeche) * dFaktor), 2);    //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                                    dSchwerpunktZ = Math.Round(dLaenge / 2 * dFaktor, 2);                                                                                                                                           //Der Schwerpunkt in Balkenlänge befindet sich mittig
                                    dIY = Math.Round((IRechteck(dbErsatz, dHöheIIProfilH) + IRechteck(dBreiteIIProfilB, dhErsatz)) / 12, 2);                                                                                        //Berechnung des Flächenträgheitsmomentes um die Y Achse
                                    dIX = ((IRechteck(dhErsatz, dBreiteIIProfilB) + IRechteck(dHöheIIProfilH, dbErsatz)) / 12);                                                                                                            //Berechnung des Flächenträgheitsmomentes um die X Achse (Steiner Anteil konnte ich noch nicht implementieren) 

                                    dGewicht = Math.Round(dVolumen / 1000000000 * dDichte, 4);
                                    dPreis = Math.Round(dGewicht * 1000 * dPreisProG, 4);

                                    //Math.Round(double, 2) Rundet auf zwei Stellen hinterm Komma

                                    txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                                    txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                                    txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                                    txtPreis.Text = Convert.ToString(dPreis) + "€";
                                    txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX) + "mm";
                                    txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                                    txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                                    txtIX.Text = Convert.ToString(dIX) + "mm^4";
                                    txtIY.Text = Convert.ToString(dIY) + "mm^4";
                                }
                            }
                        }
                    }

                    break;


            }

        }


        //Verwendete Unterprogramme*********************************************************

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

        private void lblFrage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Bezugspunkt unten Links");
        }

        private void itmEVoll_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        public void lbl_CatiaStart_Click(object sender, RoutedEventArgs e)
        {
            Catia c = new Catia();
            new CatiaControl(dBreite / 2, dHöhe / 2, dBreiteI / 2, dHöheI / 2, dBreiteA/2, dHöheA/2, dDurchmesser, dDurchmesserAussen, dDurchmesserInnen, dBreiteb1, dBreiteb2, dHöheTIProfilh, dBreiteITProfilB, dHöheITProfilH, dHöheIIProfilh, dBreiteIIProfilB, dHöheIIProfilH, dLaenge, Profil, MatAuswahl);
            if (!(c.CATIALaeuft()))
            {

                MessageBox.Show("Catia läuft nicht!");

            }

        }
    }
}
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

                txtLänge.Text = " ";


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

                txtLänge.Text = " ";



            }

            if (Auswahl == "itmVierkantrohr")
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

                lblBreiteB.Visibility = Visibility.Visible;
                lblHöheTIProfilh.Visibility = Visibility.Hidden;
                txt4.Visibility = Visibility.Visible;
                txt4.Text = " ";

                lblHöheH.Visibility = Visibility.Visible;
                lblBreiteITProfilB.Visibility = Visibility.Hidden;
                txt5.Visibility = Visibility.Visible;
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

                txtLänge.Text = " ";




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

                txtLänge.Text = " ";


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

                txtLänge.Text = " ";
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

                txtLänge.Text = " ";
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







        //Start der Berechnung***************************************************************************

        
        private void btnRechne_Click(object sender, RoutedEventArgs e)
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
                    break;


                case "System.Windows.Controls.ComboBoxItem: Stahl":
                    dDichte = 7874;
                    dPreisProG = 0.002;
                    break;

                case "System.Windows.Controls.ComboBoxItem: Aluminium":
                    dDichte = 2700;
                    dPreisProG = 0.006;
                    break;

                case "System.Windows.Controls.ComboBoxItem: Kunststoff":
                    dDichte = 900;
                    dPreisProG = 0.004;
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
                    string sBreite;
                    string sHöhe;

                    double dBreite;
                    double dHöhe;


                    //Übergabe der Eingabevariablen in String Variablen
                    sBreite = txt2.Text;
                    sHöhe = txt3.Text;
                    sLängeEingabe = txtLänge.Text;


                    //Übergabe der String Variablen nach Double
                    dHöhe = Convert.ToDouble(sHöhe);
                    dBreite = Convert.ToDouble(sBreite);
                    dLaenge = Convert.ToDouble(sLängeEingabe);

                    //Innendurchmesser kleiner?
                    if (dHöhe > dBreite)
                    {
                        MessageBox.Show("Die Höhe muss kleiner sein als die Breite");
                    }

                    //Maße korrekt
                    else
                    {
                        //Variablen für Case Rechteck

                        //Übergabe der Eingabevariablen in String Variablen
                        sBreite = txt2.Text;
                        sHöhe = txt3.Text;
                        sLängeEingabe = txtLänge.Text;


                        //Übergabe der String Variablen nach Double
                        dHöhe = Convert.ToDouble(sHöhe);
                        dBreite = Convert.ToDouble(sBreite);
                        dLaenge = Convert.ToDouble(sLängeEingabe);

                        //Innendurchmesser kleiner?
                        if (dHöhe > dBreite)
                        {
                            MessageBox.Show("Die Höhe muss kleiner sein als die Breite");
                        }

                        //Maße korrekt


                        MessageBox.Show("Dichte:  " + dDichte.ToString() + "  kg/m^3");

                        // Berechnungen in Double Variablen
                        dFlaeche = (FlaecheRechteck(dBreite, dHöhe)) * dFaktor;
                        dVolumen = dFlaeche * dLaenge * dFaktor;
                        dSchwerpunktX = (dBreite / 2) * dFaktor;
                        dSchwerpunktY = (dBreite / 2) * dFaktor;
                        dSchwerpunktZ = (dLaenge / 2) * dFaktor;
                        dIX = (IRechteck(dBreite, dHöhe)) * dFaktor;
                        dIY = (IRechteck(dHöhe, dBreite)) * dFaktor;
                        dGewicht = dVolumen * dDichte * dFaktor;
                        dPreis = dGewicht * dPreisProG * dFaktor;

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


                case "itmT_Profil":
                    sLängeEingabe = txtLänge.Text;
                    string sBreiteb1Eingabe = txt2.Text;
                    string sBreiteb2Eingabe = txt3.Text;
                    string sHöheTIProfilhEingabe = txt4.Text;
                    string sBreiteITProfilBEingabe = txt5.Text;
                    string sHöheITProfilHEingabe = txt6.Text;




                    double dBreiteb1;
                    double dBreiteb2;
                    double dHöheTIProfilh;
                    double dBreiteITProfilB;
                    double dHöheITProfilH;

                    do
                    {
                        do //Zahlen werden eingelesen und geprüft ob sie mit dem Datentyp und übereinstimmen und ob es sich um eine Zahl handelt 

                        {

                            if ((PrüfungZahl(sLängeEingabe) || PrüfungZahl(sBreiteb1Eingabe) || PrüfungZahl(sBreiteb2Eingabe) || PrüfungZahl(sHöheTIProfilhEingabe) || PrüfungZahl(sBreiteITProfilBEingabe) || PrüfungZahl(sHöheITProfilHEingabe)) == false)
                            {
                                MessageBox.Show("Eingabe ist keine Zahl.");

                            }

                            if ((sLängeEingabe.Contains(" ") || sBreiteb1Eingabe.Contains(" ") || sBreiteb2Eingabe.Contains(" ") || sHöheTIProfilhEingabe.Contains(" ") || sBreiteITProfilBEingabe.Contains(" ") || sHöheITProfilHEingabe.Contains(" ")) == true)

                            {
                                MessageBox.Show("Eingabe darf keine Leerzeichen enthalten");
                            }



                        }
                        while (((PrüfungZahl(sLängeEingabe) || PrüfungZahl(sBreiteb1Eingabe) || PrüfungZahl(sBreiteb2Eingabe) || PrüfungZahl(sHöheTIProfilhEingabe) || PrüfungZahl(sBreiteITProfilBEingabe) || PrüfungZahl(sHöheITProfilHEingabe)) == false) || ((sLängeEingabe.Contains(" ") || sBreiteb1Eingabe.Contains(" ") || sBreiteb2Eingabe.Contains(" ") || sHöheTIProfilhEingabe.Contains(" ") || sBreiteITProfilBEingabe.Contains(" ") || sHöheITProfilHEingabe.Contains(" ")) == true));
                        //Prüfung sehr lang eventuel findet man noch was besseres
                        //wenn es sich bei den Eingaben um Zahlen handelt werden die eingaben in Double konvertiert

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
                        if (dHöheTIProfilh > dHöheITProfilH)
                        {
                            MessageBox.Show("Ihre Eingegebene Gesamthöhe H muss größer als Höhe h sein.");
                        }

                    }
                    while (dLaenge <= 0 || dBreiteb1 <= 0 || dBreiteb2 <= 0 || dHöheTIProfilh <= 0 || dBreiteITProfilB <= 0 || dHöheITProfilH <= 0 || dHöheTIProfilh > dHöheITProfilH);

                    //Sind die Zahlen Größer Null und die Rippenbreite schmaler als Die Gutbreite wird mit den Berechnungen begonnen
                    double dRechteck1Fläche = FlaecheRechteck(dBreiteITProfilB, dHöheITProfilH);                                                                 //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                    double dRechteck2Fläche = FlaecheRechteck(dBreiteb1, dHöheTIProfilh);                                                          //mehrfach wiederkehrende Unterprogrammaufrufe wurden ausgegliedert
                    double dRechteck3Fläche = FlaecheRechteck(dBreiteb2, dHöheTIProfilh);

                    double dhErsatz = dHöheITProfilH - dHöheTIProfilh;
                    double dbErsatz = dBreiteb1 + dBreiteb2 + dBreiteITProfilB;
                    

                    dFlaeche = Math.Round((dRechteck1Fläche + dRechteck2Fläche + dRechteck3Fläche) * dFaktor, 4);                                                                   //Flächenberechnung der T-Träger wird aus zwei Rechtecken zusammengesetzt die über das Unterprogramm Rechteck() aus der Balkenberechnung
                    dVolumen = Math.Round(dFlaeche * dLaenge * dFaktor, 4);                                                                               // Volumen wird durch die bereits berechnete Fläche und die Trägerlänge berechnet
                    dSchwerpunktX = Math.Round(((dRechteck1Fläche * SRechteck(dBreiteITProfilB) + dRechteck2Fläche * SRechteck(dBreiteb1) + dRechteck3Fläche * SRechteck(dBreiteb2)) / dFlaeche) * dFaktor, 2);     //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                    dSchwerpunktY = Math.Round(-1 * (((dRechteck1Fläche * SRechteck(dHöheITProfilH) + dRechteck2Fläche * SRechteck(dHöheTIProfilh) + dRechteck3Fläche * SRechteck(dHöheTIProfilh)) / dFlaeche) * dFaktor), 2);    //Schwerpunkt wird durch Zusammenrechnung der einzelschwerpunkte der Rechtecke berechnet
                    dSchwerpunktZ = Math.Round((dLaenge / 2) * dFaktor, 2);                                                                               //Der Schwerpunkt in Balkenlänge befindet sich mittig
                    dIY = Math.Round((IRechteck(dbErsatz, dHöheITProfilH) + IRechteck(dBreiteITProfilB, dhErsatz)) / 12, 2);                                  //Berechnung des Flächenträgheitsmomentes um die Y Achse
                    //double dIX = ((IRechteck(hHöheRip, bBreiteRip) + IRechteck(hHöhe, bBreite)) / 12); //Berechnung des Flächenträgheitsmomentes um die X Achse (Steiner Anteil konnte ich noch nicht implementieren) 
                    dGewicht = Math.Round((dVolumen / 1000000000) * dDichte, 4);
                    dPreis = dGewicht * 1000 * dPreisProG;





                   

                    txtVolumen.Text = Convert.ToString(dVolumen) + "mm³";
                    txtFlaeche.Text = Convert.ToString(dFlaeche) + "mm²";
                    txtMasse.Text = Convert.ToString(dGewicht) + "kg";
                    txtPreis.Text = Convert.ToString(dPreis) + "€";
                    txtSchwerpunktX.Text = Convert.ToString(dSchwerpunktX) + "mm";
                    txtSchwerpunktY.Text = Convert.ToString(dSchwerpunktY) + "mm";
                    txtSchwerpunktZ.Text = Convert.ToString(dSchwerpunktZ) + "mm";
                    txtIX.Text = Convert.ToString(dIX) + "mm^4";
                    txtIY.Text = Convert.ToString(dIY) + "mm^4";

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


                        this.dSchwerpunktX = dDurchmesserAussen / 2;
                        dSchwerpunktY = dDurchmesserAussen / 2;
                        dSchwerpunktZ = dLängeRohr / 2;
                        dIX = IRohr(dDurchmesserAussen, dDurchmesserInnen);
                        dIY = IRohr(dDurchmesserAussen, dDurchmesserInnen);
                        dGewicht = dVolumen * dDichte;

                        // Übergabe Double in String Variablen
                        txtVolumen.Text = Convert.ToString(dVolumen);
                        txtFlaeche.Text = Convert.ToString(dFlaeche);
                        txtMasse.Text = Convert.ToString(dGewicht);
                        txtPreis.Text = Convert.ToString(dPreisProG);
                        txtSchwerpunktX.Text = Convert.ToString(this.dSchwerpunktX);
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
    }
}




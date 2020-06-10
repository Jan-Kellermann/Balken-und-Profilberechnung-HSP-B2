using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using INFITF;
using MECMOD;
using PARTITF;
using CATMat;

namespace Balken_und_Profilberechnung
{
    public class CatiaControl
    {
        private double v;
        private double dHöhe1;

        public CatiaControl(double dBreite, double dHöhe, double dBreiteI, double dHöheI, double dBreiteA, double dHöheA, double dDurchmesser, double dDurchmesserAussen, double dDurchmesserInnen, double dLaenge, int Profil)
        {
            try
            {

                Catia cc = new Catia();

                // Finde Catia Prozess
                if (cc.CATIALaeuft())
                {
                    //Rechteck
                    if (Profil.Equals(1))
                    {
                        Console.WriteLine("0");

                        // Öffne ein neues Part
                        cc.ErzeugePart();
                        Console.WriteLine("1");

                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();
                        Console.WriteLine("2");

                        // Generiere ein Profil
                        cc.ErzeugeProfilRechteck(dBreite, dHöhe);
                        Console.WriteLine("3");

                        // Extrudiere Balken
                        cc.ErzeugeBalken(dLaenge);
                        Console.WriteLine("4");

                        cc.setMaterial();


                        // cc.Screenshot("test");
                        //cc.openFile();
                        //cc.changeUserParameter(2);
                        // cc.FEM();
                    }
                    //Vierkant
                    if (Profil.Equals(2))
                    {
                      
                        // Öffne ein neues Part
                        cc.ErzeugePart();
                        
                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();
                        cc.ErzeugeProfilVierkant(dBreiteI, dHöheI, dBreiteA, dHöheA);

                        cc.ErzeugeBalken(dLaenge);

                        cc.setMaterial();
                    }
                    //Rund
                    if (Profil.Equals(3))
                    {

                        // Öffne ein neues Part
                        cc.ErzeugePart();

                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();

                        // Generiere ein Profil
                        cc.ErzeugeProfilRund(dDurchmesser);

                        // Extrudiere Balken
                        cc.ErzeugeBalken(dLaenge);

                        cc.setMaterial();
                    }
                    //Rohr
                    if (Profil.Equals(4))
                    {

                        // Öffne ein neues Part
                        cc.ErzeugePart();

                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();

                        // Generiere ein Profil
                        cc.ErzeugeProfilRohr(dDurchmesserAussen, dDurchmesserInnen);


                        // Extrudiere Balken
                        cc.ErzeugeBalken(dLaenge);


                        cc.setMaterial();
                    }


                    //T
                    if (Profil.Equals(5))
                    {

                        // Öffne ein neues Part
                        cc.ErzeugePart();

                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();
                    }
                    //I
                    if (Profil.Equals(6))
                    {

                        // Öffne ein neues Part
                        cc.ErzeugePart();

                        // Erstelle eine Skizze
                        cc.ErstelleLeereSkizze();
                    }
                }
                else
                {
                    Console.WriteLine("Keine laufende Catia Application gefunden");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception aufgetreten");
            }

        }
    }
}

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
        public CatiaControl()
        {
            try
            {

                Catia cc = new Catia();

                // Finde Catia Prozess
                if (cc.CATIALaeuft())
                {

                    
                    Console.WriteLine("0");

                    // Öffne ein neues Part
                    cc.ErzeugePart();
                    Console.WriteLine("1");

                    // Erstelle eine Skizze
                    cc.ErstelleLeereSkizze();
                    Console.WriteLine("2");

                    // Generiere ein Profil
                    cc.ErzeugeProfil(20, 10);
                    Console.WriteLine("3");

                    // Extrudiere Balken
                    cc.ErzeugeBalken(300);
                    Console.WriteLine("4");

                    cc.setMaterial();
                   

                    // cc.Screenshot("test");
                    //cc.openFile();
                    //cc.changeUserParameter(2);
                    // cc.FEM();

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
            Console.WriteLine("Fertig - Taste drücken.");
            Console.ReadKey();

        }
    }
}

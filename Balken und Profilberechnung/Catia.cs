using System;
using System.Windows;
using CATMat;
using INFITF;
using MECMOD;
using PARTITF;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Balken_und_Profilberechnung
{
    public class Catia
    {
        INFITF.Application hsp_catiaApp;
        MECMOD.PartDocument hsp_catiaPart;
        MECMOD.Sketch hsp_catiaProfil;

        public bool CATIALaeuft()
        {
            try
            {
                object catiaObject = System.Runtime.InteropServices.Marshal.GetActiveObject(
                    "CATIA.Application");
                hsp_catiaApp = (INFITF.Application)catiaObject;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean ErzeugePart()
        {
            INFITF.Documents catDocuments1 = hsp_catiaApp.Documents;
            hsp_catiaPart = catDocuments1.Add("Part") as MECMOD.PartDocument;
            return true;
        }

        public void ErstelleLeereSkizze()
        {
            HybridBodies catHybridBodies1 = hsp_catiaPart.Part.HybridBodies;
            HybridBody catHybridBody1;
            try
            {
                catHybridBody1 = catHybridBodies1.Item("Geometrisches Set.1");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein geometrisches Set gefunden! " + Environment.NewLine +
                    "Ein PART manuell erzeugen und ein darauf achten, dass 'Geometisches Set' aktiviert ist.",
                    "Fehler", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            catHybridBody1.set_Name("Profile");
            Sketches catSketches1 = catHybridBody1.HybridSketches;
            OriginElements catOriginElements = hsp_catiaPart.Part.OriginElements;
            Reference catReference1 = (Reference)catOriginElements.PlaneYZ;
            hsp_catiaProfil = catSketches1.Add(catReference1);

            ErzeugeAchsensystem();

            hsp_catiaPart.Part.Update();
        }

        private void ErzeugeAchsensystem()
        {
            object[] arr = new object[] {0.0, 0.0, 0.0,
                                         0.0, 1.0, 0.0,
                                         0.0, 0.0, 1.0 };
            hsp_catiaProfil.SetAbsoluteAxisData(arr);
        }

        public void ErzeugeProfil(Double b, Double h)
        {
            hsp_catiaProfil.set_Name("Rechteck");

            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            Point2D catPoint2D1 = catFactory2D1.CreatePoint(-b, h);
            Point2D catPoint2D2 = catFactory2D1.CreatePoint(b, h);
            Point2D catPoint2D3 = catFactory2D1.CreatePoint(b, -h);
            Point2D catPoint2D4 = catFactory2D1.CreatePoint(-b, -h);

            Line2D catLine2D1 = catFactory2D1.CreateLine(-b, h, b, h);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            Line2D catLine2D2 = catFactory2D1.CreateLine(b, h, b, -h);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            Line2D catLine2D3 = catFactory2D1.CreateLine(b, -h, -b, -h);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            Line2D catLine2D4 = catFactory2D1.CreateLine(-b, -h, -b, h);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D1;

            hsp_catiaProfil.CloseEdition();
            hsp_catiaPart.Part.Update();
        }

        public void setMaterial()
        {

            String sFilePath = @"C:\Program Files\Dassault Systemes\B28\win_b64\startup\materials\German\Catalog.CATMaterial";
            MaterialDocument oMaterial_document = (MaterialDocument)hsp_catiaApp.Documents.Open(sFilePath);
            MaterialFamilies cFamilies_list = oMaterial_document.Families;

            foreach (MaterialFamily mf in cFamilies_list)
            {
                Console.WriteLine(mf.get_Name());
            }

            MaterialFamily myMf = cFamilies_list.Item("Metall");
            foreach (Material mat in myMf.Materials)
            {
                Console.WriteLine(mat.get_Name());
            }

            Material myStahl = myMf.Materials.Item("Stahl");

            MaterialManager partMatManager = hsp_catiaPart.Part.GetItem("CATMatManagerVBExt") as MaterialManager;
            
            short linkMode = 0;
            partMatManager.ApplyMaterialOnPart(hsp_catiaPart.Part, myStahl, linkMode);

            linkMode = 1;
            partMatManager.ApplyMaterialOnBody(hsp_catiaPart.Part.MainBody, myStahl, linkMode);
        }

        public void ErzeugeBalken(Double l)
        {
            hsp_catiaPart.Part.InWorkObject = hsp_catiaPart.Part.MainBody;

            ShapeFactory catShapeFactory1 = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hsp_catiaProfil, l);

            catPad1.set_Name("Balken");

            hsp_catiaPart.Part.Update();
        }


    }
}

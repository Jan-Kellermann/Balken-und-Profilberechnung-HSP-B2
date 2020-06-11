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

        public void ErzeugeProfilRechteck(Double b, Double h)
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

        public void setMaterial(int MatAuswahl)
        {

            String sFilePath = @"C:\Program Files\Dassault Systemes\B28\win_b64\startup\materials\German\Catalog.CATMaterial";
            MaterialDocument oMaterial_document = (MaterialDocument)hsp_catiaApp.Documents.Open(sFilePath);
            MaterialFamilies cFamilies_list = oMaterial_document.Families;

            foreach (MaterialFamily mf in cFamilies_list)
            {
                Console.WriteLine(mf.get_Name());
            }

            if (MatAuswahl.Equals(1))
            {
                MaterialFamily myMfh = cFamilies_list.Item("Holz");
                foreach (Material mat in myMfh.Materials)
                {
                    Console.WriteLine(mat.get_Name());
                }

                Material myHolz = myMfh.Materials.Item("Holz");

                MaterialManager partMatManager = hsp_catiaPart.Part.GetItem("CATMatManagerVBExt") as MaterialManager;

                short linkMode = 0;
                partMatManager.ApplyMaterialOnPart(hsp_catiaPart.Part, myHolz, linkMode);

                linkMode = 1;
                partMatManager.ApplyMaterialOnBody(hsp_catiaPart.Part.MainBody, myHolz, linkMode);

            }

            if (MatAuswahl.Equals(2))
            {
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

            if (MatAuswahl.Equals(3))
            {
                MaterialFamily myMf = cFamilies_list.Item("Metall");
                foreach (Material mat in myMf.Materials)
                {
                    Console.WriteLine(mat.get_Name());
                }

                Material myAlu = myMf.Materials.Item("Aluminium");

                MaterialManager partMatManager = hsp_catiaPart.Part.GetItem("CATMatManagerVBExt") as MaterialManager;

                short linkMode = 0;
                partMatManager.ApplyMaterialOnPart(hsp_catiaPart.Part, myAlu, linkMode);

                linkMode = 1;
                partMatManager.ApplyMaterialOnBody(hsp_catiaPart.Part.MainBody, myAlu, linkMode);

            }

            if (MatAuswahl.Equals(4))
            {
                MaterialFamily myMfp = cFamilies_list.Item("Andere");
                foreach (Material mat in myMfp.Materials)
                {
                    Console.WriteLine(mat.get_Name());
                }

                Material myPlastik = myMfp.Materials.Item("Plastik");

                MaterialManager partMatManager = hsp_catiaPart.Part.GetItem("CATMatManagerVBExt") as MaterialManager;

                short linkMode = 0;
                partMatManager.ApplyMaterialOnPart(hsp_catiaPart.Part, myPlastik, linkMode);

                linkMode = 1;
                partMatManager.ApplyMaterialOnBody(hsp_catiaPart.Part.MainBody, myPlastik, linkMode);

            }

            if (MatAuswahl.Equals(5))
            {
                MaterialFamily myMf = cFamilies_list.Item("Metall");
                foreach (Material mat in myMf.Materials)
                {
                    Console.WriteLine(mat.get_Name());
                }

                Material myTitan = myMf.Materials.Item("Titan");

                MaterialManager partMatManager = hsp_catiaPart.Part.GetItem("CATMatManagerVBExt") as MaterialManager;

                short linkMode = 0;
                partMatManager.ApplyMaterialOnPart(hsp_catiaPart.Part, myTitan, linkMode);

                linkMode = 1;
                partMatManager.ApplyMaterialOnBody(hsp_catiaPart.Part.MainBody, myTitan, linkMode);

            }
        }

            public void ErzeugeBalken(Double l)
        {
            hsp_catiaPart.Part.InWorkObject = hsp_catiaPart.Part.MainBody;

            ShapeFactory catShapeFactory1 = (ShapeFactory)hsp_catiaPart.Part.ShapeFactory;
            Pad catPad1 = catShapeFactory1.AddNewPad(hsp_catiaProfil, l);

            catPad1.set_Name("Balken");

            hsp_catiaPart.Part.Update();
        }
        public void ErzeugeProfilRund(Double Durchmesser)
        {

            hsp_catiaProfil.set_Name("Rundprofil");

            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            // Kreisprofil erzeugen, Punkte
            catFactory2D1.CreateClosedCircle(0.000000, 0.000000, Durchmesser / 2);


            hsp_catiaProfil.CloseEdition();
            hsp_catiaPart.Part.Update();
        }

        public void ErzeugeProfilRohr(Double dDurchmesserAussen, double dDurchmesserInnen)
        {
            ErzeugeProfilRund(dDurchmesserAussen);
            ErzeugeProfilRund(dDurchmesserInnen);

        }
        public void ErzeugeProfilVierkant(Double dBreiteI, double dHöheI, double dBreiteA, double dHöheA)
        {
            ErzeugeProfilRechteck(dBreiteI,dHöheI);
            ErzeugeProfilRechteck(dBreiteA,dHöheA);

        }

        public void ErzeugeTProfil(double dBreiteb1, double dBreiteb2, double dHöheTIProfilh, double dBreiteITProfilB, double dHöheITProfilH)
        {
            // Skizze umbenennen
            hsp_catiaProfil.set_Name("T-Profil");

            // T-Profil in Skizze einzeichnen
            // Skizze oeffnen
            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            // T-Profil erzeugen

            // erst die Punkte
            Point2D catPoint2D1 = catFactory2D1.CreatePoint(0, dHöheITProfilH);
            Point2D catPoint2D2 = catFactory2D1.CreatePoint(0, dHöheITProfilH - dHöheTIProfilh);
            Point2D catPoint2D3 = catFactory2D1.CreatePoint((dBreiteITProfilB / 2) - (dBreiteb1 / 2), dHöheITProfilH - dHöheTIProfilh);
            Point2D catPoint2D4 = catFactory2D1.CreatePoint((dBreiteITProfilB / 2) - (dBreiteb1 / 2), 0);
            Point2D catPoint2D5 = catFactory2D1.CreatePoint((dBreiteITProfilB / 2) + (dBreiteb2 / 2), 0);
            Point2D catPoint2D6 = catFactory2D1.CreatePoint((dBreiteITProfilB / 2) + (dBreiteb2 / 2), dHöheITProfilH - dHöheTIProfilh);
            Point2D catPoint2D7 = catFactory2D1.CreatePoint(dBreiteITProfilB, dHöheITProfilH - dHöheTIProfilh);
            Point2D catPoint2D8 = catFactory2D1.CreatePoint(dBreiteITProfilB, dHöheITProfilH);

            // dann die Linien
            Line2D catLine2D1 = catFactory2D1.CreateLine(0, dHöheITProfilH, 0, dHöheITProfilH - dHöheTIProfilh);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            Line2D catLine2D2 = catFactory2D1.CreateLine(0, dHöheITProfilH - dHöheTIProfilh, (dBreiteITProfilB / 2) - (dBreiteb1 / 2), dHöheITProfilH - dHöheTIProfilh);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            Line2D catLine2D3 = catFactory2D1.CreateLine((dBreiteITProfilB / 2) - (dBreiteb1 / 2), dHöheITProfilH - dBreiteb1, (dBreiteITProfilB / 2) - (dBreiteb1 / 2), 0);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            Line2D catLine2D4 = catFactory2D1.CreateLine((dBreiteITProfilB / 2) - (dBreiteb1 / 2), 0, (dBreiteITProfilB / 2) + (dBreiteb1 / 2), 0);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;

            Line2D catLine2D5 = catFactory2D1.CreateLine((dBreiteITProfilB / 2) + (dBreiteb2 / 2), 0, (dBreiteITProfilB / 2) + (dBreiteb2 / 2), dHöheITProfilH - dBreiteb2);
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;

            Line2D catLine2D6 = catFactory2D1.CreateLine((dBreiteITProfilB / 2) + (dBreiteb2 / 2), dHöheITProfilH - dBreiteb2, dBreiteITProfilB, dHöheITProfilH - dBreiteb2);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D7;

            Line2D catLine2D7 = catFactory2D1.CreateLine(dBreiteITProfilB, dHöheITProfilH - dBreiteb2, dBreiteITProfilB, dHöheITProfilH);
            catLine2D7.StartPoint = catPoint2D7;
            catLine2D7.EndPoint = catPoint2D8;

            Line2D catLine2D8 = catFactory2D1.CreateLine(dBreiteITProfilB, dHöheITProfilH, 0, dHöheITProfilH);
            catLine2D8.StartPoint = catPoint2D8;
            catLine2D8.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hsp_catiaProfil.CloseEdition();

            // Part aktualisieren
            hsp_catiaPart.Part.Update();
        }

        public void ErzeugeIProfil(double dBreiteb1, double dBreiteb2, double dHöheIIProfilh, double dBreiteIIProfilB, double dHöheIIProfilH)
        {
            Double Stegbreite = dBreiteIIProfilB - (dBreiteb1 + dBreiteb2);

            // Werte aus Variablen verarbeiten
            Double HalbeBreite = dBreiteIIProfilB / 2;
            Double HalbeHoehe = dHöheIIProfilH / 2;
            Double Steghoehe = dHöheIIProfilh / 2;
            Double HalbeStegbreite = Stegbreite / 2;


            // Skizze umbenennen
            hsp_catiaProfil.set_Name("I-Profil");

            // I-Profil in Skizze einzeichnen
            // Skizze oeffnen
            Factory2D catFactory2D1 = hsp_catiaProfil.OpenEdition();

            // I-Profil erzeugen

            // erst die Punkte
            Point2D catPoint2D1 = catFactory2D1.CreatePoint(-HalbeBreite, HalbeHoehe);
            Point2D catPoint2D2 = catFactory2D1.CreatePoint(HalbeBreite, HalbeHoehe);
            Point2D catPoint2D3 = catFactory2D1.CreatePoint(HalbeBreite, Steghoehe);
            Point2D catPoint2D4 = catFactory2D1.CreatePoint(HalbeStegbreite, Steghoehe);
            Point2D catPoint2D5 = catFactory2D1.CreatePoint(HalbeStegbreite, -Steghoehe);
            Point2D catPoint2D6 = catFactory2D1.CreatePoint(HalbeBreite, -Steghoehe);
            Point2D catPoint2D7 = catFactory2D1.CreatePoint(HalbeBreite, -HalbeHoehe);
            Point2D catPoint2D8 = catFactory2D1.CreatePoint(-HalbeBreite, -HalbeHoehe);
            Point2D catPoint2D9 = catFactory2D1.CreatePoint(-HalbeBreite, -Steghoehe);
            Point2D catPoint2D10 = catFactory2D1.CreatePoint(-HalbeStegbreite, -Steghoehe);
            Point2D catPoint2D11 = catFactory2D1.CreatePoint(-HalbeStegbreite, Steghoehe);
            Point2D catPoint2D12 = catFactory2D1.CreatePoint(-HalbeBreite, Steghoehe);


            // dann die Linien
            Line2D catLine2D1 = catFactory2D1.CreateLine(-HalbeBreite, HalbeHoehe, HalbeBreite, HalbeHoehe);
            catLine2D1.StartPoint = catPoint2D1;
            catLine2D1.EndPoint = catPoint2D2;

            Line2D catLine2D2 = catFactory2D1.CreateLine(HalbeBreite, HalbeHoehe, HalbeBreite, Steghoehe);
            catLine2D2.StartPoint = catPoint2D2;
            catLine2D2.EndPoint = catPoint2D3;

            Line2D catLine2D3 = catFactory2D1.CreateLine(HalbeBreite, Steghoehe, HalbeStegbreite, Steghoehe);
            catLine2D3.StartPoint = catPoint2D3;
            catLine2D3.EndPoint = catPoint2D4;

            Line2D catLine2D4 = catFactory2D1.CreateLine(HalbeStegbreite, Steghoehe, HalbeStegbreite, -Steghoehe);
            catLine2D4.StartPoint = catPoint2D4;
            catLine2D4.EndPoint = catPoint2D5;

            Line2D catLine2D5 = catFactory2D1.CreateLine(HalbeStegbreite, -Steghoehe, HalbeBreite, -Steghoehe);
            catLine2D5.StartPoint = catPoint2D5;
            catLine2D5.EndPoint = catPoint2D6;

            Line2D catLine2D6 = catFactory2D1.CreateLine(HalbeBreite, -Steghoehe, HalbeBreite, -HalbeHoehe);
            catLine2D6.StartPoint = catPoint2D6;
            catLine2D6.EndPoint = catPoint2D7;

            Line2D catLine2D7 = catFactory2D1.CreateLine(HalbeBreite, -HalbeHoehe, -HalbeBreite, -HalbeHoehe);
            catLine2D7.StartPoint = catPoint2D7;
            catLine2D7.EndPoint = catPoint2D8;

            Line2D catLine2D8 = catFactory2D1.CreateLine(-HalbeBreite, -HalbeHoehe, -HalbeBreite, -Steghoehe);
            catLine2D8.StartPoint = catPoint2D8;
            catLine2D8.EndPoint = catPoint2D9;

            Line2D catLine2D9 = catFactory2D1.CreateLine(-HalbeBreite, -Steghoehe, -HalbeStegbreite, -Steghoehe);
            catLine2D9.StartPoint = catPoint2D9;
            catLine2D9.EndPoint = catPoint2D10;

            Line2D catLine2D10 = catFactory2D1.CreateLine(-HalbeStegbreite, -Steghoehe, -HalbeStegbreite, Steghoehe);
            catLine2D10.StartPoint = catPoint2D10;
            catLine2D10.EndPoint = catPoint2D11;

            Line2D catLine2D11 = catFactory2D1.CreateLine(-HalbeStegbreite, Steghoehe, -HalbeBreite, Steghoehe);
            catLine2D11.StartPoint = catPoint2D11;
            catLine2D11.EndPoint = catPoint2D12;

            Line2D catLine2D12 = catFactory2D1.CreateLine(-HalbeBreite, Steghoehe, -HalbeBreite, HalbeHoehe);
            catLine2D12.StartPoint = catPoint2D12;
            catLine2D12.EndPoint = catPoint2D1;

            // Skizzierer verlassen
            hsp_catiaProfil.CloseEdition();

            // Part aktualisieren
            hsp_catiaPart.Part.Update();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Threading.Tasks;

namespace GetränkeAutomat.Knöpfe
{

    public partial class Getränke : UserControl
    {
        private float GetränkePreis;
        private string momentanesGeld;
        private string EingegebenesGeld;

        MainWindow mainWindow = Application.Current.MainWindow as MainWindow;



        public Getränke()
        {
            InitializeComponent();
        }


        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {



            GetränkePreis = 1.99f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrer Cola.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {


            GetränkePreis = 1.99f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrer Fanta.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }

        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {

            GetränkePreis = 0.89f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrem Wasser.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {

            GetränkePreis = 2.98f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrem Red Bull.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {

            GetränkePreis = 1.49f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrer Apfel Schorle.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }
        }

        private async void Button_Click_5(object sender, RoutedEventArgs e)
        {

            GetränkePreis = 0.89f;
            EingegebenesGeld = mainWindow.tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(EingegebenesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (flMomentanesGeld >= GetränkePreis)
            {
                float neuesGeld = flMomentanesGeld - GetränkePreis;

                mainWindow.tbEingezahltesGeld.Text = "Geld: 0€";
                mainWindow.AuszahlSumme.Text = $"{neuesGeld}€";
                mainWindow.tbGetränk.Text = "Danke für Ihren Einkauf! Viel Spaß mit Ihrem Eiskaffee.";
                await Task.Delay(3000);
                mainWindow.tbGetränk.Text = "";
                mainWindow.AuszahlSumme.Text = "";
            }
            else
            {
                mainWindow.tbEingezahltesGeld.Text = "Bitte werfen Sie mehr Geld ein";
                await Task.Delay(2000);
                mainWindow.tbEingezahltesGeld.Text = EingegebenesGeld;
            }
        }
    }
}
            
    


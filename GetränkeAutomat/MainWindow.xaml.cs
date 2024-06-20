
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Data;

namespace GetränkeAutomat
{
    public partial class MainWindow : Window
    {

        public string EingegebenesGeld;
        public float GeldPlus;
        public float flEingegebenesGeld;
        public float flMomentanesGeld;
        public string MomentanesGeld; 
        public string ZusammengerechnetesGeld;
        public float flneuesGeld;
        public string strneuesGeld;

        private async void Button_Click(object sender, RoutedEventArgs e)
        {


            EingegebenesGeld = GeldEingabe.Text;
            MomentanesGeld = tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(MomentanesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            if (float.TryParse(EingegebenesGeld, out float GeldPlus))
            {

                flneuesGeld = flMomentanesGeld + GeldPlus;
                strneuesGeld = $"Geld: {flneuesGeld:F2}€";
                tbEingezahltesGeld.Text = strneuesGeld;
                return;
            }
            else
            {
                ZusammengerechnetesGeld = tbEingezahltesGeld.Text;
                tbEingezahltesGeld.Text = "ERROR";
                await Task.Delay(800);
                tbEingezahltesGeld.Text = ZusammengerechnetesGeld;
                return;   
            }
        }

        private async void Ausgeben_Click(object sender, RoutedEventArgs e)
        {
            EingegebenesGeld = GeldEingabe.Text;
            MomentanesGeld = tbEingezahltesGeld.Text;

            string floatGeld = Regex.Match(MomentanesGeld, @"[-+]?\d+(\,\d+)?").Value;
            float.TryParse(floatGeld, out float flMomentanesGeld);

            AuszahlSumme.Text = $"{flMomentanesGeld:F2}€";
            await Task.Delay(800);
            AuszahlSumme.Text = "";
            tbEingezahltesGeld.Text = "Geld: 0€";
            return;
        }

        private void Getränke_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
    }


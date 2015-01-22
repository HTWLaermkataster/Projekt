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
using Microsoft.Win32;
using System.Xml;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.IO;
using System.Configuration;
using System.Xml.XPath;
using System.Xml.Linq;



namespace Laerm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Messwerte temp;
        OpenFileDialog openAny = new OpenFileDialog();
        SaveFileDialog saveAs = new SaveFileDialog();
        string path = "";
            //Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void beenden_button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void karte_button_Click(object sender, RoutedEventArgs e)
        {
            string filename = "";
            openAny.ShowDialog();
            filename = openAny.FileName;

            try
            {
               
            }
            catch (Exception) { }
        }

        private void werthinzufugen_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                temp = new Messwerte(Convert.ToDouble(XWert_box.Text), Convert.ToDouble(YWert_box.Text), Convert.ToDouble(dbWert_Box.Text), Nameorts_box.Text, Datum.Text);

                if (File.Exists(@path) == false)
                {
                    XElement first = new XElement("Messwerte");
                    first.Save(@path);
                }

                    XElement root = XElement.Load(@path);

                    XElement mWert = new XElement("Messwert",
                               new XElement("Datum", Convert.ToString(temp.datum)),
                               new XElement("xWert", Convert.ToString(temp.xwert)),
                               new XElement("yWert", Convert.ToString(temp.ywert)),
                               new XElement("dbWert", Convert.ToString(temp.dbwert)),
                               new XElement("OrtsName", temp.OrtsName)
                    );

                    root.Add(mWert);
                    root.Save(@path);

                    XWert_box.Clear();
                    YWert_box.Clear();
                    dbWert_Box.Clear();
                    Nameorts_box.Clear();
                    Datum.Text = "";
                }

            catch (Exception )         {    }
        }

        private void datenspeichern_button_Click(object sender, RoutedEventArgs e)
        {
            string speicherort = "";
            Nullable<bool> result = saveAs.ShowDialog();
            XElement Load = XElement.Load(@path);
            
            XElement first = new XElement(Load);
            if (result == true)
            {
                speicherort = saveAs.FileName;
            }
            try { first.Save(@speicherort); path = speicherort; }

            catch (Exception) { }

        }

        private void datenladen_button_Click(object sender, RoutedEventArgs e)
        {
            string filename="";
            Nullable<bool> result = openAny.ShowDialog();

            if (result == true)
                 filename = openAny.FileName;

            XElement Laden = XElement.Load(@filename);
            path = filename;

            
        }

        private void MesswerteAnzeigen_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@path);
            }
            catch { }
        }

        private void NeueDateiButton_Click(object sender, RoutedEventArgs e)
        {
            string speicherort = "";
            Nullable<bool> result = saveAs.ShowDialog();     
            if (result == true)
            {
                speicherort = saveAs.FileName;
            }
            try { XElement first = new XElement("Messwerte"); first.Save(@speicherort); path = speicherort; }
            catch (Exception) { }
        }
    }
}

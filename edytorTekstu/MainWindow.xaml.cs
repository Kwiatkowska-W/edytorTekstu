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
using System.IO;
using Microsoft.Win32;

namespace edytorTekstu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
private void btnOpenFile_Click(object sender, RoutedEventArgs e) { 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) 
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName); }

        private void changeStyle_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontStyle = FontStyles.Italic;
        }

        private void changeStyle2_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Times, Times New Roman");
        }

        private void changeStyle3_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Arial, Arial");
        }

        private void changeStyle5_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.FontWeight = FontWeights.Bold;
        }

        private void changeStyle4_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.TextDecorations = TextDecorations.Underline;
        }

        private void changeStyle6_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void changeStyle_Click(object sender, RoutedEventArgs e)
        // {
        //  Button: Action{ FileDialog:}
        //  }
    }
}

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

namespace WPF_TheConverter
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

        private void Button_FeetToMeters_Click(object sender, RoutedEventArgs e)
        {
            double meters;

            if (ValidateInputFeet())
            {
                meters = Convert.ToDouble(Textbox_Feet.Text) * 0.3048;

                Textbox_Meters.Text = meters.ToString();
            }
        }

        private void Button_MetersToFeet_Click(object sender, RoutedEventArgs e)
        {
            double feet;

            if (ValidateInputMeters())
            {
                feet = Convert.ToDouble(Textbox_Meters.Text) / 0.3048;

                Textbox_Feet.Text = feet.ToString();
            }
        }

        private bool ValidateInputFeet()
        {
            bool validInputsFeet = true;

            if (
                !double.TryParse(Textbox_Feet.Text, out double feet)
                )
            {
                MessageBox.Show("Please enter a valid number for feet!");
                validInputsFeet = false;
                ResetInputs();
            }

            return validInputsFeet;
        }

        private bool ValidateInputMeters()
        {
            bool validInputsMeters = true;

            if (
                !double.TryParse(Textbox_Meters.Text, out double meters)
                )
            {
                MessageBox.Show("Please enter a valid number for meters!");
                validInputsMeters = false;
                ResetInputs();
            }

            return validInputsMeters;
        }

        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            Textbox_Feet.Text = String.Empty;
            Textbox_Meters.Text = String.Empty;
        }

        private void ResetInputs()
        {
            Textbox_Feet.Text = "";
            Textbox_Meters.Text = "";

            Textbox_Feet.Focus();
        }
    }
}

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

namespace WPF_TIECalc
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

        //Validates user input
        private bool ValidateInputs()
        {
            bool validInputs = true;

            if (
                !double.TryParse(Textbox_Principal.Text, out double principal) ||
                !double.TryParse(Textbox_Rate.Text, out double rate) ||
                !double.TryParse(Textbox_Time.Text, out double time)
                )
            {
                MessageBox.Show("Please enter valid numbers for each field");
                validInputs = false;
                ResetInputs();
            }

            return validInputs;
        }

        //Resets inputs with invalid input
        private void ResetInputs()
        {
            Textbox_Principal.Text = "";
            Textbox_Rate.Text = "";
            Textbox_Time.Text = "";

            Textbox_Principal.Focus();
        }

        //Calculation
        private void Button_Calculate_Click(object sender, RoutedEventArgs e)
        {
            double interest;

            if (ValidateInputs())
            {
                interest = double.Parse(Textbox_Principal.Text) * (1 + (double.Parse(Textbox_Rate.Text)/100) * (double.Parse(Textbox_Time.Text)/365));

                interest = Math.Round(interest, 2); 

                SolutionWindow solutionWindow = new SolutionWindow(interest);

                solutionWindow.ShowDialog();

                Label_MValue.Content = "$" + interest;
            }
        }

        //Exits application
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

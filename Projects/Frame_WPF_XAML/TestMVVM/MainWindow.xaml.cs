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

namespace TestMVVM
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

        private void myButtonClicked(object sender, EventArgs e)
        {
            // this.MyButton.Background = Brushes.Green;
            // this.MyButton.Content = "OK";
            // MessageBox.Show("Button Clicked");
            this.MyTextBox.Text = "Fail";
        }

        private void myButtonClicked1(object sender, EventArgs e)
        {
            this.MyTextBox.Text = "Pass";
        }
    }
}

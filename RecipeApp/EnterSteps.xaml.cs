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
using System.Windows.Shapes;

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for EnterSteps.xaml
    /// </summary>
    public partial class EnterSteps : Window
    {
        private string value;
        public EnterSteps(int count)
        {
            InitializeComponent();
            this.value = "Enter Step " + count + " Description";
            lblvalue.Content = value;
        }
        public string des { get; private set; }
        private void SubmitDescription(object sender, RoutedEventArgs e)
        {
            des = Description.Text;
            Close();
        }
    }
}

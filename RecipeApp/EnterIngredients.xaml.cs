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
    /// Interaction logic for EnterIngredients.xaml
    /// </summary>
    public partial class EnterIngredients : Window
    {
        
        public EnterIngredients()
        {
            InitializeComponent();
           
        }
        public string name { get; private set; }
        public double qty { get; private set; }
        public string unit { get; private set; }
        public int calories { get; private set; }
        public string fg { get; private set; }

        private void SubmitIngredients(object sender, RoutedEventArgs e)
        {
            name = Name.Text;
            qty = double.Parse(Quantity.Text);
            unit = Unit.Text;
            calories = int.Parse(Calories.Text);
            fg = FG.Text;
            Close();
        }
    }
}

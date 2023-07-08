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
    /// Interaction logic for FindRecipe.xaml
    /// </summary>
    public partial class FindRecipe : Window
    {
        public FindRecipe()
        {
            InitializeComponent();
        }

        public string Rname { get; private set; }
        public string Ringredients { get; private set; }
        public string Rfg { get; private set; }
        public int RC { get; private set; }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Rname = RecipeName.Text;
            Ringredients = Ingredients.Text;
            Rfg = FoodGroup.Text;
            RC = int.Parse(Calories.Text);

            Close();
        }
    }
}

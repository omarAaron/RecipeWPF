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
    /// Interaction logic for EnterRecipe.xaml
    /// </summary>
    public partial class EnterRecipe : Window
    {
        public EnterRecipe()
        {
            InitializeComponent();
        }

        public string RN { get; private set; }
        public int ING { get; private set; }
        public int STP { get; private set; }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            RN = RecipeName.Text;
            ING = int.Parse(Ingredients.Text);
            STP = int.Parse(Steps.Text);

            Close();
        }
    }
}

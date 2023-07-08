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

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Recipe> recipe = new List<Recipe>();
        private List<Ingredients> ingredients = new List<Ingredients>();
        private List<Steps> steps = new List<Steps>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterRecipe(object sender, RoutedEventArgs e)
        {
            var inputRecipe = new EnterRecipe();

            var resRecipe = new Recipe();
            var resIngredients = new List<Ingredients>();
            var resSteps = new List<Steps>();

            if (inputRecipe.ShowDialog() == false)
            {
                string RecipeNameInput = inputRecipe.RN;
                int NumIngredients = inputRecipe.ING;
                int NumSteps = inputRecipe.STP;

                for (int i = 0; i < NumIngredients; i++)
                {
                    var inputIngredients = new EnterIngredients();
                    inputIngredients.ShowDialog();

                  
                        var Ing = new Ingredients
                        {
                            Name = inputIngredients.name,
                            Quantity = inputIngredients.qty,
                            Unit = inputIngredients.unit,
                            Calories = inputIngredients.calories,
                            FoodGroup = inputIngredients.fg

                        };

                    resIngredients.Add(Ing);
                    inputIngredients.Close();
                }

                for (int i = 0; i < NumSteps; i++)
                {
                    var inputSteps = new EnterSteps(i + 1);
                    inputSteps.ShowDialog();


                    var Step = new Steps()
                    {
                        Description = inputSteps.des
                    };

                    resSteps.Add(Step);
                    inputSteps.Close();
                }

                if (!string.IsNullOrEmpty(RecipeNameInput))
                {

                    resRecipe = new Recipe()
                    {
                        Name = RecipeNameInput,
                        Ingredients = resIngredients,
                        Steps = resSteps
                    };

                    recipe.Add(resRecipe);
                }
            }

            
        }

        private void DisplayRecipe(object sender, RoutedEventArgs e)
        {
            // Clear the text display before displaying the recipe details
            txtDisplay.Text = string.Empty;

            // Check if there are any recipes available
            if (recipe.Count > 0)
            {
                foreach (var recipe in recipe)
                {
                    // Display the recipe details
                    txtDisplay.Text += $"Recipe: {recipe.Name}\n";
                    txtDisplay.Text += "Ingredients:\n";

                    // Check if the recipe has any ingredients
                    if (recipe.Ingredients != null && recipe.Ingredients.Count > 0)
                    {
                        foreach (var ingredient in recipe.Ingredients)
                        {
                            // Display the ingredient details
                            txtDisplay.Text += $"- Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit: {ingredient.Unit}, Calories: {ingredient.Calories}\n";
                        }
                    }

                    // Display the steps
                    txtDisplay.Text += "Steps:\n";
                    if (recipe.Steps != null && recipe.Steps.Count > 0)
                    {
                        foreach (var step in recipe.Steps)
                        {
                            txtDisplay.Text += $"- {step.Description}\n";
                        }
                    }
                    else
                    {
                        txtDisplay.Text += "No steps provided\n";
                    }
                }
            }
            else
            {
                txtDisplay.Text = "No recipes available";
            }
        }

        private void FilterRecipe(object sender, RoutedEventArgs e)
        {
            var filterRecipe = new FindRecipe();
            filterRecipe.ShowDialog();

            string filtername = filterRecipe.Rname;
            string filteringredients = filterRecipe.Ringredients;
            string filterfoodgroup = filterRecipe.Rfg;
            int filtercalories = filterRecipe.RC;


            if(filtername != "")
            {
                txtDisplay.Text = string.Empty;
                foreach (var item in recipe)
                {
                    if(item.Name == filtername)
                    {
                        // Display the recipe details
                        txtDisplay.Text += $"Recipe: {item.Name}\n";
                        txtDisplay.Text += "Ingredients:\n";

                       
                            foreach (var ingredient in item.Ingredients)
                            {
                                // Display the ingredient details
                                txtDisplay.Text += $"- Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit: {ingredient.Unit}, FoodGroup: {ingredient.FoodGroup}, FoodGroup: {ingredient.FoodGroup}, Calories: {ingredient.Calories}\n";
                            }
                        

                        // Display the steps
                        txtDisplay.Text += "Steps:\n";
                        if (item.Steps != null && item.Steps.Count > 0)
                        {
                            foreach (var step in item.Steps)
                            {
                                txtDisplay.Text += $"- {step.Description}\n";
                            }
                        }
                        else
                        {
                            txtDisplay.Text += "No steps provided\n";
                        }
                    }
                }
            }

            if (filteringredients != "")
            {
                txtDisplay.Text = string.Empty;
                for (int i = 0; i < recipe.Count; i++)
                {
                    if (recipe[i].Ingredients[i].Name == filteringredients)
                    {
                        // Display the recipe details
                        txtDisplay.Text += $"Recipe: {recipe[i].Name}\n";
                        txtDisplay.Text += "Ingredients:\n";


                        foreach (var ingredient in recipe[i].Ingredients)
                        {
                            // Display the ingredient details
                            txtDisplay.Text += $"- Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit: {ingredient.Unit}, FoodGroup: {ingredient.FoodGroup}, Calories: {ingredient.Calories}\n";
                        }


                        // Display the steps
                        txtDisplay.Text += "Steps:\n";
                        if (recipe[i].Steps != null && recipe[i].Steps.Count > 0)
                        {
                            foreach (var step in recipe[i].Steps)
                            {
                                txtDisplay.Text += $"- {step.Description}\n";
                            }
                        }
                        else
                        {
                            txtDisplay.Text += "No steps provided\n";
                        }
                    }
                }
            }

            if (filterfoodgroup != "")
            {
                txtDisplay.Text = string.Empty;
                for (int i = 0; i < recipe.Count; i++)
                {
                    if (recipe[i].Ingredients[i].FoodGroup == filterfoodgroup)
                    {
                        // Display the recipe details
                        txtDisplay.Text += $"Recipe: {recipe[i].Name}\n";
                        txtDisplay.Text += "Ingredients:\n";


                        foreach (var ingredient in recipe[i].Ingredients)
                        {
                            // Display the ingredient details
                            txtDisplay.Text += $"- Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit: {ingredient.Unit}, FoodGroup: {ingredient.FoodGroup}, Calories: {ingredient.Calories}\n";
                        }


                        // Display the steps
                        txtDisplay.Text += "Steps:\n";
                        if (recipe[i].Steps != null && recipe[i].Steps.Count > 0)
                        {
                            foreach (var step in recipe[i].Steps)
                            {
                                txtDisplay.Text += $"- {step.Description}\n";
                            }
                        }
                        else
                        {
                            txtDisplay.Text += "No steps provided\n";
                        }
                    }
                }
            }

            if (filtercalories != 0)
            {
                txtDisplay.Text = string.Empty;
                for (int i = 0; i < recipe.Count; i++)
                {
                    for (int x = 0; x < recipe[i].Ingredients.Count; x++)
                    {
                        if (recipe[i].Ingredients[x].Calories == filtercalories)
                        {
                            // Display the recipe details
                            txtDisplay.Text += $"Recipe: {recipe[i].Name}\n";
                            txtDisplay.Text += "Ingredients:\n";


                            foreach (var ingredient in recipe[i].Ingredients)
                            {
                                // Display the ingredient details
                                txtDisplay.Text += $"- Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit: {ingredient.Unit}, FoodGroup: {ingredient.FoodGroup}, Calories: {ingredient.Calories}\n";
                            }


                            // Display the steps
                            txtDisplay.Text += "Steps:\n";
                            if (recipe[i].Steps != null && recipe[i].Steps.Count > 0)
                            {
                                foreach (var step in recipe[i].Steps)
                                {
                                    txtDisplay.Text += $"- {step.Description}\n";
                                }
                            }
                            else
                            {
                                txtDisplay.Text += "No steps provided\n";
                            }
                        }
                    }
                }
            }
        }
    }
}

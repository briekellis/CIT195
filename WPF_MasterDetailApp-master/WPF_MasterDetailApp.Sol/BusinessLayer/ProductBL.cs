using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Troglodyte Talent Agency",
                Address = "465 Jurassic Lane",
                City = "Bedrock"
            };
        }


        private List<Product> GetProductData()
        {
            return new List<Product>()
            {
                                new Product()
                {
                    Types = "Grass/Poison",
                    Number = 1,
                    Name = "Bulbasaur",
                    Description = "For some time after its birth, it grows by gaining nourishment from the seed on its back.",
                    Gender = Product.GenderType.female,
                    Pokedex = true
                },
                new Product()
                {
                    Types = "Grass/Poison",
                    Number = 2,
                    Name = "Ivysaur",
                    Description = "When the bud on its back starts swelling, a sweet aroma wafts to indicate the flowers coming bloom.",
                    Gender = Product.GenderType.female,
                    Pokedex = true
                },
                new Product()
                {
                    Types = "Grass/Poison",
                    Number = 3,
                    Name = "Venusaur",
                    Description = "After a rainy day, the flower on its back smells stronger. The scent attracts other Pokémon.",
                    Gender = Product.GenderType.female,
                    Pokedex = true
                },
                new Product()
                {
                Types = "Fire",
    Number = 5,
    Name = "Charmeleon",
    Description = "In the rocky mountains where Charmeleon live, their fiery tails shine at night like stars.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Fire/Flying",
    Number = 6,
    Name = "Charizard",
    Description = "It is said that Charizards fire burns hotter if it has experienced harsh battles.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Water",
    Number = 7,
    Name = "Squirtle",
    Description = "It shelters itself in its shell then strikes back with spouts of water at every opportunity.",
    Gender = Product.GenderType.female,
    Pokedex = true
},
new Product()
{
    Types = "Water",
    Number = 8,
    Name = "Wartortle",
    Description = "It is said to live 10,000 years. Its furry tail is popular as a symbol of longevity.",
    Gender = Product.GenderType.female,
    Pokedex = true
},
new Product()
{
    Types = "Water",
    Number = 9,
    Name = "Blastoise",
    Description = "The jets of water it spouts from the rocket cannons on its shell can punch through thick steel.",
    Gender = Product.GenderType.female,
    Pokedex = true
},
new Product()
{
    Types = "Electric",
    Number = 25,
    Name = "Pikachu",
    Description = "It occasionally uses an electric shock to recharge a fellow Pikachu that is in a weakened state.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Electric",
    Number = 26,
    Name = "Riachu",
    Description = "Its tail discharges electricity into the ground, protecting it from getting shocked.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Grass/Poison",
    Number = 43,
    Name = "Oddish",
    Description = "It often plants its root feet in the ground during the day and sows seeds as it walks about at night.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Grass/Poison",
    Number = 44,
    Name = "Gloom",
    Description = "The honey it drools from its mouth smells so atrocious, it can curl noses more than a mile away.",
    Gender = Product.GenderType.male,
    Pokedex = true
},
new Product()
{
    Types = "Grass/Poison",
    Number = 46,
    Name = "Vileplume",
    Description = "Its petals are the largest in the world. As it walks, it scatters extremely allergenic pollen.",
    Gender = Product.GenderType.male,
    Pokedex = true
}
            };
        }

        #endregion

        #region EVENTS


        #endregion

    }
}

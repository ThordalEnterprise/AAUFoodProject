using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using AAUFoodProject.Model;
using Xamarin.Forms;

namespace AAUFoodProject.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;

        public List<FoodItem> FoodItems { get; set; }

        public AddFoodItemData()
        {
            client = new FirebaseClient("https://aaudelevery.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                

                //Pizzas
                new FoodItem
                {
                    ProductID = 1,
                    CategoryID = 2,
                    ImageUrl = "Pepperoni.png",
                    Name = "Pepperoni",
                    Description = "Mozzarella ost, pepperoni",
                    Price = 27
                },
             new FoodItem
                {
                    ProductID = 2,
                    CategoryID = 2,
                    ImageUrl = "Margherita.png",
                    Name = "Margherita",
                    Description = "Tomatsauce, mozzarella ost",
                    Price = 23
                },
             new FoodItem
                {
                    ProductID = 3,
                    CategoryID = 2,
                    ImageUrl = "Hawaiian.png",
                    Name = "Hawaiian",
                    Description = "Skinke, ananas, ekstra mozzarella",
                    Price = 32
                },
             new FoodItem
                {
                    ProductID = 4,
                    CategoryID = 2,
                    ImageUrl = "Capri.png",
                    Name = "Capri",
                    Description = "Skinke, champignon",
                    Price = 35
                },
               new FoodItem
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageUrl = "PepperoniFeast.png",
                    Name = "Pepperoni Feast",
                    Description = "Ekstra pepperoni, ekstra mozzarella",
                    Price = 37
                },
                  new FoodItem
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageUrl = "NewYorker.png",
                    Name = "New Yorker",
                    Description = "Oksekød, bacon, emmentaler ost",
                    Price = 40
                },
                     new FoodItem
                {
                    ProductID = 7,
                    CategoryID = 2,
                    ImageUrl = "SpicyChicken.png",
                    Name = "Spicy Chicken",
                    Description = "Kylling, peberfrugt, champignon, jalapeños, chili flager",
                    Price = 40
                },
                        new FoodItem
                {
                    ProductID = 8,
                    CategoryID = 2,
                    ImageUrl = "Tropical.png",
                    Name = "Tropical",
                    Description = "Pepperoni, rødløg, ananas, forårsløg",
                    Price = 35
                },

                //desserts


             new FoodItem
                {
                    ProductID = 9,
                    CategoryID = 3,
                    ImageUrl = "Chokolade.png",
                    Name = "Sundae m. chokolade",
                    Description = "McDonald 's vidunderlige Sundae is toppet med varm chokoladesauce",
                    Price = 15
                },

                   new FoodItem
                {
                    ProductID = 10,
                    CategoryID = 3,
                    ImageUrl = "Karamel.png",
                    Name = "Sundae m. karamel",
                    Description = "McDonald 's vidunderlige Sundae is toppet med varm karamelsauce",
                    Price = 15
                },

                          new FoodItem
                {
                    ProductID = 11,
                    CategoryID = 3,
                    ImageUrl = "ChokoladeMuffin.png",
                    Name = "Chokolade Muffin",
                    Description = "Prøv vores nye Chokolade Muffin med lækre chokoladestykker. Prøv den alene eller med en god kop kaffe til.",
                    Price = 20
                },

             new FoodItem
                {
                    ProductID = 12,
                    CategoryID = 3,
                    ImageUrl = "Jordbor.png",
                    Name = "Sundae m. jordbær",
                    Description = "McDonald 's vidunderlige Sundae is toppet med varm jordbærsauce",
                    Price = 15
                },

                          new FoodItem
                {
                    ProductID = 13,
                    CategoryID = 3,
                    ImageUrl = "McFlurryMarabouOreo.png",
                    Name = "McFlurry Marabou Oreo",
                    Description = "McFlurry® Marabou Oreo På menuen fra 17/3 2020 Cremet is med knuste stykker af Marabou chokolade og Oreo®",
                    Price = 25
                },
                                       new FoodItem
                {
                    ProductID = 14,
                    CategoryID = 3,
                    ImageUrl = "McFlurrySmarties.png",
                    Name = "McFlurry Smarties",
                    Description = "Der er nogle ting, der bare hører sammen. Derfor er McFlurry® Smarties® Mini nu tilbage på menuen. I forbindelse med re-lanceringen af McFlurry Mini Smarties, har vi også lanceret nye bægre til alle vores McFlurry’s, hvor plastiklåget er væk. Det sparer miljøet for mere end et ton plastik om måneden.",
                    Price = 25
                },

              new FoodItem
                {
                    ProductID = 15,
                    CategoryID = 3,
                    ImageUrl = "McFlurryDaim.png",
                    Name = "McFlurry Daim",
                    Description = "Denne lækre sag består af cremet is og knuste stykker af sprødt Daim. I forbindelse med re-lanceringen af McFlurry Mini Smarties, har vi også lanceret nye bægre til alle vores McFlurry’s, hvor plastiklåget er væk. Det sparer miljøet for mere end et ton plastik om måneden.",
                    Price = 25
                },
                  new FoodItem
                {
                    ProductID = 16,
                    CategoryID = 3,
                    ImageUrl = "McFlurryMarabouDaim.png",
                    Name = "McFlurry Marabou Daim",
                    Description = "På menuen fra 17/3 2020 Cremet is med knuste stykker af Marabou chokolade, karamelsovs og sprød Daim.",
                    Price = 25
                },


                // veggies

                       new FoodItem
                {
                    ProductID = 17,
                    CategoryID = 4,
                    ImageUrl = "HomestyleVegetar.png",
                    Name = "Homestyle Vegetar",
                    Description = "Homestyle Vegetar med en krydrede quinoa-peberfrugt-bøf, smelteost m. emmentaler, frisk tomat, salat, hvide løg og mayo – alt sammen i en lækker blød brioche bolle. Velbekomme! Fås i udvalgte restauranter.",
                    Price = 45
                },

                                new FoodItem
                {
                    ProductID = 18,
                    CategoryID = 4,
                    ImageUrl = "GrovVegetar.png",
                    Name = "GrovVegetar",
                    Description = "På menuen fra 28/6 2018 GrovVegetar er er til dig, som gerne vil have et alternativ til den klassiske burger med kød. Mellem de to grovboller har den en farverig quinoa-peberfrugt-bøf, smelteost med cheddar og to slags sauce. Ja, og så er der selvfølgelig også salat. Det er trods alt en vegetarburger, selvom man nemt kan komme i tvivl.",
                    Price = 45
                },

        new FoodItem
                {
                    ProductID = 19,
                    CategoryID = 4,
                    ImageUrl = "McFeastVegetar.png",
                    Name = "McFeast Vegetar",
                    Description = "Der er sket noget nyt med vores klassiske McFeast for nu kan du også få den med krydret quinoa-peberfrugt-bøf. Det er stadig den klassiker, du kender med en skive smelteost med cheddar, salat, tomat, hakkede løg, pickles, sennep, ketchup og mayo – men nu i en vegetar-udgave. Fås kun i udvalgte restauranter",
                    Price = 40
                },

            new FoodItem
                {
                    ProductID = 20,
                    CategoryID = 4,
                    ImageUrl = "GrovFeastVegetar.png",
                    Name = "GrovFeast Vegetar",
                    Description = "McFeast Vegetar med groft brød. En krydret quinoa-peberfrugt-bøf, smelteost med cheddar, salat, tomat, hakkede løg, pickles, sennep, ketchup og mayo i grovbolle. Fås kun i udvalgte restauranter",
                    Price = 45
                },

                 new FoodItem
                {
                    ProductID = 21,
                    CategoryID = 4,
                    ImageUrl = "VeganSpicy.png",
                    Name = "Vegan Spicy",
                    Description = "Vegan ost, tomater, peberfrugt, rødløg, jalapeños, chili flager",
                    Price = 33
                },
                      new FoodItem
                {
                    ProductID = 22,
                    CategoryID = 4,
                    ImageUrl = "VeganVeggi.png",
                    Name = "Vegan Veggi",
                    Description = "Vegan ost, tomater, peberfrugt, rødløg, champignon, forårsløg",
                    Price = 33
                },
                      new FoodItem
                {
                    ProductID = 23,
                    CategoryID = 4,
                    ImageUrl = "VeganMargherita.png",
                    Name = "Vegan Margherita",
                    Description = "Tomatsauce, vegan ost",
                    Price = 33
                },
                              new FoodItem
                {
                    ProductID = 24,
                    CategoryID = 4,
                    ImageUrl = "GlutenfriPizzaMargherita.png",
                    Name = "Glutenfri Pizza Margherita",
                    Description = "En margherita pizza bagt på en speciel glutenfri bund (20cm).",
                    Price = 45
                },
                              //Drinks
                                new FoodItem
                {
                    ProductID = 25,
                    CategoryID = 5,
                    ImageUrl = "fanta.png",
                    Name = "Fanta",
                    Description = "Fanta is a brand of fruit-flavored carbonated soft drinks created by Coca-Cola Deutschland under the leadership of German businessman Max Keith. ",
                    Price = 15
                },
                                new FoodItem
                {
                    ProductID = 26,
                    CategoryID = 5,
                    ImageUrl = "cokecola.png",
                    Name = "Coke-Cola",
                    Description = "Coca-Cola, or Coke, is a carbonated soft drink manufactured by The Coca-Cola Company. Originally marketed as a temperance drink and intended as a patent medicine, it was invented in the late 19th century .",
                    Price = 15
                },
                                new FoodItem
                {
                    ProductID = 27,
                    CategoryID = 5,
                    ImageUrl = "ol.png",
                    Name = "Tuborg Øl",
                    Description = "Grøn Tuborg færdes ligeså hjemmevandt i fine selskaber, som når der skal drikkes en kold bajer over hækken. Grøn er en øl du kan stole på, altid sig selv og altid frisk. ",
                    Price = 25
                },
                                new FoodItem
                {
                    ProductID = 28,
                    CategoryID = 5,
                    ImageUrl = "sporten.png",
                    Name = "Carlsberg Sport",
                    Description = "Carlsberg SPORT is a tasty and refreshing sports soda with dextrose and lemon/lime flavour.",
                    Price = 15
                },
                                new FoodItem
                {
                    ProductID = 29,
                    CategoryID = 5,
                    ImageUrl = "mojito.png",
                    Name = "Mojito",
                    Description = "Mojito is a traditional Cuban highball. Traditionally, a mojito is a cocktail that consists of five ingredients: white rum, sugar, lime juice, soda water, and mint. ",
                    Price = 35
                },
                                new FoodItem
                {
                    ProductID = 30,
                    CategoryID = 5,
                    ImageUrl = "martini.png",
                    Name = "Martini",
                    Description = "The martini is a cocktail made with gin and vermouth, and garnished with an olive or a lemon twist. Over the years, the martini has become one of the best-known mixed alcoholic beverages. ",
                    Price = 35
                },
                                new FoodItem
                {
                    ProductID = 31,
                    CategoryID = 5,
                    ImageUrl = "chocolate.png",
                    Name = "Chocolate",
                    Description = "Hot chocolate, also known as drinking chocolate, cocoa, and as chocolate tea in Nigeria, is a heated drink consisting of shaved chocolate, melted chocolate or cocoa powder, heated milk or water, and usually a sweetener. ",
                    Price = 20
                },
                                new FoodItem
                {
                    ProductID = 32,
                    CategoryID = 5,
                    ImageUrl = "ccoff.png",
                    Name = "Coffee",
                    Description = "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain Coffea species. When coffee berries turn from green to bright red in color – indicating ripeness – they are picked, processed, and dried.",
                    Price = 10
                },
//burgers
                new FoodItem
                {
                    ProductID = 33,
                    CategoryID = 1,
                    ImageUrl = "HomestyleSyltede.png",
                    Name = "Homestyle Syltede Rødløg",
                    Description = "Homestyle Syltede Rødløg med en saftig bøf, 2 " +
                    "skiver sprødstegt bacon, bataviasalat, mayo, syltede rødløg, smelteost m. " +
                    "cheddar og masser af cajunsauce alt sammen i en lækker brioche bolle.",
                    Price = 43
                },
                new FoodItem
                {
                    ProductID = 34,
                    CategoryID = 1,
                    ImageUrl = "HomestyleKyllingBacon.png",
                    Name = "Homestyle Kylling Bacon",
                    Description = "Homestyle Kylling Bacon med en saftig bøf af kylling, " +
                    "2 skiver sprødstegt bacon, hvide løg, smelteost m. emmentaler, frisk tomat, " +
                    "bataviasalat og mayo – alt sammen i en lækker blød brioche bolle.",
                    Price = 52
                },
                 new FoodItem
                {
                    ProductID = 35,
                    CategoryID = 1,
                    ImageUrl = "DoubleBigTastyBacon.png",
                    Name = "Double Big Tasty Bacon",
                    Description = "Hvis du godt kan li’ Big Tasty Bacon, så bør du prøve Double Big Tasty Bacon. Den er nemlig med alt det gode fra Big Tasty Bacon; saftig bøf, smelteost med emmentaler, tomat, salat, løg, Big Tasty sauce og sprød bacon - bare med hele to saftige bøffer og mere ost. Altså hele 226 g kød.",
                    Price = 44
                },
                   new FoodItem
                {
                    ProductID = 36,
                    CategoryID = 1,
                    ImageUrl = "DoubleQuarterPounder.png",
                    Name = "Double Quarter Pounder",
                    Description = "På menuen fra 04/08-2020 – 28/09-2020 Man skal ikke pille ved en klassiker fra McDonald’s, men med vores Double Quarter Pounder har vi gjort en undtagelse. For på overfladen minder den meget om sin forgænger med to skiver af smelteost med cheddar, hakkede løg, pickles, sennep og ketchup serveret i bolle med sesam. Forskellen er, at i en Double Quarter Pounder får du en ekstra bøf af 100% oksekød. Det håber vi er okay.",
                    Price = 53
                },
                new FoodItem
                {
                    ProductID = 37,
                    CategoryID = 1,
                    ImageUrl = "GrovFeast.png",
                    Name = "GrovFeast",
                    Description = "Vores GrovFeast har fået en ny, saftig bøf, som består af en bøf af 100% oksekød.",
                    Price = 39
                },
                    new FoodItem
                {
                    ProductID = 38,
                    CategoryID = 1,
                    ImageUrl = "BigMac.png",
                    Name = "Big Mac",
                    Description = "Big Mac er vores verdenskendte burger. Det er ikke uden grund at den er svær at modstå. Big Mac'en består af to bøffer af 100% oksekød, Big Mac sauce, smelteost med cheddar, sprød salat, hakkede løg og pickles - serveret i en bolle med sesam.",
                    Price = 46
                },
                     new FoodItem
                {
                    ProductID = 39,
                    CategoryID = 1,
                    ImageUrl = "HomestyleTroffelmayo.png",
                    Name = "Homestyle Trøffel mayo",
                    Description = "På menuen fra 23/6 -29/9 2020 Med vores Homestyle Trøffelmayo er der skruet helt op for smagen med trøffelmayo, saftig bøf, smelteost med emmentaler og en blanding af ristet og grillet løg. Fås i udvalgte restauranter",
                    Price = 64
                },
                     new FoodItem
                {
                    ProductID = 40,
                    CategoryID = 1,
                    ImageUrl = "GrovFeastKylling.png",
                    Name = "GrovFeast Kylling",
                    Description = "McFeast Kylling med groft brød. Sprød kylling, smelteost med cheddar, salat, tomat, hakkede løg, pickles, sennep, ketchup og mayo i grovbolle. Fås kun i udvalgte restauranter",
                    Price = 48
                },







             };
        }

        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}

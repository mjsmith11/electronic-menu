using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_models.Models;

namespace data_models
{
    public class DbInitializer
    {
        public static void Initialize(NetCoreMenuContext context)
        {
            context.Database.EnsureCreated();

            if(!context.Tables.Any())
            {
                // no tables
                seedTables(context);
            }
            if(!context.MenuItems.Any())
            {
                seedMenuItems(context);
            }
            if(!context.Css.Any())
            {
                seedCss(context);
            }
            if(!context.SystemOptions.Any())
            {
                seedSystemOpts(context);
            }

            
        }

        public static void seedTables(NetCoreMenuContext context)
        {
            var tables = new Table[]
            {
                new Table { TableID = 1, IsEmpty = true },
                new Table { TableID = 2, IsEmpty = true },
                new Table { TableID = 3, IsEmpty = true },
                new Table { TableID = 4, IsEmpty = true },
                new Table { TableID = 5, IsEmpty = true },
                new Table { TableID = 6, IsEmpty = true },
                new Table { TableID = 7, IsEmpty = true },
                new Table { TableID = 8, IsEmpty = true },
                new Table { TableID = 9, IsEmpty = true },
                new Table { TableID = 10, IsEmpty = true }
            };

            foreach (Table t in tables)
            {
                context.Tables.Add(t);
            }
            context.SaveChanges();
        }

        public static void seedMenuItems(NetCoreMenuContext context)
        {
            var items = new MenuItem[]
            {
                new MenuItem {Category="Appetizers", Title = "Shrimp Cocktail", IsSpecialty=true, Description = "4 jumbo shrimp served with our spicy, signature cocktail sauce", Price = 15, IsAvailable=true},
                new MenuItem {Category="Appetizers", Title = "Seared Ahi Tuna", Description = "Perfectly complemented by a spirited sauce with hints of ginger, mustard and beer", Price = 17, IsAvailable=true},
                new MenuItem {Category="Appetizers", Title = "Chilled Seafood Tower", Description = "Maine lobster, king crab legs and knuckles, colossal lump crab meat and jumbo cocktail shrimp served with both Sriracha-lime seafood sauce and cocktail sauce.", Price = 59, IsAvailable=true},
                new MenuItem {Category="Appetizers", Title = "Sizzling Blue Crab Cakes", Description = "Two jumbo lump crab cakes served with sizzling lemon butter.", Price = 19, IsAvailable=true},
                new MenuItem {Category="Appetizers", Title = "Veal Osso Buco Ravoli", Description = "Saffron-infused pasta filled with veal osso buco and fresh mozzarella cheese and topped with a white wine demi-glace.", Price = 15, IsAvailable=true},
                new MenuItem {Category="Appetizers", Title = "Crispy Lobster Tail", Description = "Cold water lobster tail, lightly fried, tossed in a spicy cream sauce, jalapeno pepper jam drizzle, tangy cucumber salad.", Price = 22, IsAvailable=true},

                new MenuItem {Category="Steaks", Title = "Porterhouse Steak", Description = "28 oz. bone-in cut, combines the rich flavor of a strip with the tenderness of a filet.", Price = 59, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Bone-In (Cowboy) Ribeye", Description = "20 oz. exceptional flavor, great balance of marbling.", Price = 49, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Ribeye", Description = "14 oz. excellent marbling, loaded with flavor.", Price = 39, DiscountPrice = 35, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Bone-In Filet", IsSpecialty=true, Description = "14 oz. lean & full of flavor.", Price = 55, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Filet Mignon", Description = "12 oz. tender, center-cut.", Price = 52, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "New York Strip", Description = "14 oz. flavorful strip with a mid-range of marbling.", Price = 41, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Flat Iron", Description = "12 oz. naturally lean, exclusively grass-fed.", Price = 42, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Bone-In Prime Rib", Description = "38 oz. of flavorful balanced marbling, slow roasted, finished to temperature. Limited availability. ", Price = 55, IsAvailable=true},
                new MenuItem {Category="Steaks", Title = "Dry-Aged NY Strip", Description = "12 oz. USDA Prime Angus. Aged 60 Days.", Price = 55, IsAvailable=true},

                new MenuItem {Category="Chops and Chicken", Title = "Lamb Chops", Description = "Locally sourced from Viking Farms, with Gorgonzola fondue.", Price = 59, IsAvailable=true},
                new MenuItem {Category="Chops and Chicken", Title = "Pork Chops", Description = "3 all-natural 7 oz. French-cut grilled chops locally sourced from Fischer Farms.", Price = 27, IsAvailable=true},
                new MenuItem {Category="Chops and Chicken", Title = "Dry-Aged Prime Chopped Steak", Description = "20 oz. with sautéed onions, smothered in Gorgonzola.", Price = 25, IsAvailable=true},
                new MenuItem {Category="Chops and Chicken", Title = "Chicken", Description = "Pan-seared chicken breasts with baby rainbow carrots, pea shoots, and a wild mushroom demi-glace.", Price = 25, IsAvailable=true},

                new MenuItem {Category="Seafood", Title = "Fresh Fish", Description = "Seasonal selection, chef preparation.", Price = 61, IsAvailable=true},
                new MenuItem {Category="Seafood", Title = "Sashimi Yellowfin Tuna", Description = "#1 grade ahi tuna, traditional accoutrements", Price = 34, IsAvailable=true},
                new MenuItem {Category="Seafood", Title = "South African Lobster Tails", Description = "Two 8 oz. succulent cold water lobster tails, drawn butter, grilled lemon.", Price = 79, IsAvailable=true},
                new MenuItem {Category="Seafood", Title = "Surf 'n Turf", IsSpecialty=true, Description = "8 oz. South African lobster tail and 8 oz. filet mignon.", Price = 79, IsAvailable=true},
                new MenuItem {Category="Seafood", Title = "French Fried Shrimp", Description = "5 golden crusted jumbo shrimp.", Price = 27, DiscountPrice = 24, IsAvailable=true},
                new MenuItem {Category="Seafood", Title = "King Crab and Shrimp Linguine", Description = "Alaskan king crab, shrimp, tomatoes, pesto-cream sauce.", Price = 38, IsAvailable=true},

                new MenuItem {Category="Salads", Title = "House Wedge", Description = "Bacon, tomatoes, creamy Gorgonzola", Price = 10, IsAvailable=true},
                new MenuItem {Category="Salads", Title = "Caesar", Description = "Romaine, shaved Parmigiano-Reggiano, herb crust.", Price = 10, IsAvailable=true},
                new MenuItem {Category="Salads", Title = "Chopped BLT", Description = "omaine with house vinaigrette, Gorgonzola cheese, tomatoes, bacon, fried onions.", Price = 10, IsAvailable=true},
                new MenuItem {Category="Salads", Title = "Spinach", Description = "Orange segments, candied walnuts, mustard-bacon vinaigrette.", Price = 10, IsAvailable=true},
                new MenuItem {Category="Salads", Title = "Sliced Tomato & Onion", Description = "Beefsteak tomatoes, onions, house vinaigrette, Gorgonzola.", Price = 10, IsAvailable=true},

                new MenuItem {Category="Sides", Title = "Sautéed Green Beans", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Creamed Spinach", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Sautéed Mushrooms", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "King Crab Mac 'n Cheese", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Loaded Baked Potato", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Baked Potato", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Redskin Mashed Potatoes", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Fresh-Cut Fries", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "House-Made Onion Rings", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Brussel Sprouts", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Au Gratin Potatoes", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Navy Bean Soup", IsAvailable=true},
                new MenuItem {Category="Sides", Title = "Tomato Juice", IsAvailable=true},

                new MenuItem {Category="Desserts", Title = "Cheesecake", Description = "Traditional New York style with a graham cracker crust.", Price = (decimal)9.5, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Cheesecake w/ Topping", Description = "With raspberry puree or hot fudge.", Price = (decimal)11.5, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Chocolate Cake", Description = "4-Layer Rich Chocolate Cake with Dark Fudge Frosting.", Price = (decimal)11.5, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Crème Brulee", IsSpecialty=true, Description = "Traditional French recipe, prepared with Madagascar vanilla beans.", Price = 8, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "White Chocolate Blueberry Bread Pudding", Description = "Served with bourbon bream sauce & vanilla ice cream. ", Price = (decimal)10.5, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Butter Cake", Description = "House-made butter cake with Luxardo cherries, crème anglaise, served with ice cream.", Price = (decimal)10.95, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Seasonal Pie", Description = "Baked locally by My Sugar Pie in nearby town of Zionsville.", Price = (decimal)11.5, IsAvailable=true},
                new MenuItem {Category="Desserts", Title = "Pie à la Mode", Description = "With vanilla ice cream.", Price = (decimal)13.5, IsAvailable=true},


            };
            foreach (MenuItem i in items)
            {
                context.MenuItems.Add(i);
            }
            context.SaveChanges();
        }

        public static void seedCss(NetCoreMenuContext context)
        {
            context.Css.Add(new Css { DisplayName = "Default", DevHref = "~/css/site.css", ProdHref = "~/css/site.min.css" });
            context.SaveChanges();
        }

        public static void seedSystemOpts(NetCoreMenuContext context)
        {
            context.SystemOptions.Add(new SystemOption { Key = SystemOption.CSS_KEY, Value = "Default" });
            context.SaveChanges();
        }
    }
}

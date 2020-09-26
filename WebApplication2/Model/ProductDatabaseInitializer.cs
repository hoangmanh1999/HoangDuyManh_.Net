using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Model
{
    public class ProductDatabaseInitializer:DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID=1,
                    CategoryName="Cars"
                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Planes"
                },
                new Category
                {
                    CategoryID=3,
                    CategoryName="Trucks"
                },
                new Category
                {
                    CategoryID=4,
                    CategoryName="Boats"
                },
                new Category
                {
                    CategoryID=5,
                    CategoryName="Rockets"
                },
                
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    ProductName="Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carconvert.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID=2,
                    ProductName="Old-time Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carearly.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID=3,
                    ProductName="Fast Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carfast.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID=4,
                    ProductName="Super Fast Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carfaster.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID=5,
                    ProductName="Old Style Racer",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="carracer.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID=6,
                    ProductName="Ace Plane",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="planeace.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID=7,
                    ProductName="Glider",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="planeglider.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID=8,
                    ProductName="Paper Plane",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="planepaper.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID=9,
                    ProductName="Propeller Plane",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="planeprop.png",
                    UnitPrice = 22.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID=10,
                    ProductName="Early Truck",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="truckearly.png",
                    UnitPrice = 22.50,
                    CategoryID = 3
                },
                 new Product
                {
                    ProductID=11,
                    ProductName="Fire Truck",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="truckfire.png",
                    UnitPrice = 22.50,
                    CategoryID = 3
                },
                  new Product
                {
                    ProductID=12,
                    ProductName="Big Truck",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="truckbig.png",
                    UnitPrice = 22.50,
                    CategoryID = 3
                },
                   new Product
                {
                    ProductID=13,
                    ProductName="Big Ship",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="boatbig.png",
                    UnitPrice = 22.50,
                    CategoryID = 4
                },
                    new Product
                {
                    ProductID=14,
                    ProductName="Paper Boat",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="boatpaper.png",
                    UnitPrice = 22.50,
                    CategoryID = 4
                },
                     new Product
                {
                    ProductID=15,
                    ProductName="Sail Boat",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="boatsail.png",
                    UnitPrice = 22.50,
                    CategoryID = 4
                },
                      new Product
                {
                    ProductID=16,
                    ProductName="Rocket",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="rocket.png",
                    UnitPrice = 22.50,
                    CategoryID = 5
                },
            };

            return products;
        }
    }
}
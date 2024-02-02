using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public static class DataBaseMoq
    {
        public static List<User>? Users { get; set; }
        public static List<Product>? Products { get; set; }

        static DataBaseMoq()
        {
            Products = new List<Product>() {
                new Product
                {
                    Images = new string[] {
                    "https://content.rozetka.com.ua/goods/images/preview/367123263.jpg",
                    "https://content2.rozetka.com.ua/goods/images/preview/367123264.jpg"
                },
                    Title = $"Навушники Hator Hyperpunk 2 Wireless Tri-mode Black/Mint (HTA-858)",
                    Cost = 2799,
                },

            new Product
            {
                Images = new string[] {
                    "https://content.rozetka.com.ua/goods/images/preview/367123263.jpg",
                    "https://content2.rozetka.com.ua/goods/images/preview/367123264.jpg"
                },
                Title = $"Навушники Hator Hyperpunk 2 Wireless Tri-mode Black/Mint (HTA-851)",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://content.rozetka.com.ua/goods/images/preview/367123263.jpg",
                    "https://content2.rozetka.com.ua/goods/images/preview/367123264.jpg"
                },
                Title = $"Навушники Hator Hyperpunk 2 Wireless Tri-mode Black/Mint (HTA-852)",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://content2.rozetka.com.ua/goods/images/preview/330083688.jpg",
                    "https://content2.rozetka.com.ua/goods/images/preview/330083689.jpg"
                },
                Title = $"Навушники Hator Hyperpunk 2 Wireless Tri-mode Black/Mint (HTA-857)",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://content.rozetka.com.ua/goods/images/preview/367123263.jpg",
                    "https://content2.rozetka.com.ua/goods/images/preview/367123264.jpg"
                },
                Title = $"Навушники Hator Hyperpunk 2 Wireless Tri-mode Black/Mint (HTA-854)",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test Test TestTestTest Test TestTestTestTest TestмTest",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            },

            new Product
            {
                Images = new string[] {
                    "https://via.placeholder.com/145x135/",
                    "https://via.placeholder.com/135x135/"
                },
                Title = $"Test",
                Cost = 2799,
            }
            };
        }
    }
}

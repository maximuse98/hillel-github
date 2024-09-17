using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Shop
{
    public class Cart
    {
        private List<Book> books = new List<Book>();
        private List<Laptop> laptops = new List<Laptop>();
        private List<Phone> phones = new List<Phone>();
        private List<TV> tvs = new List<TV>();
        private List<Fridge> fridges = new List<Fridge>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddLaptop(Laptop laptop)
        {
            laptops.Add(laptop);
        }

        public void AddPhone(Phone phone)
        {
            phones.Add(phone);
        }

        public void AddTV(TV tv)
        {
            tvs.Add(tv);
        }

        public void AddFridge(Fridge fridge)
        {
            fridges.Add(fridge);
        }

        public void PrintCart()
        {
            if (books.Count > 0)
            {
                Console.WriteLine("Books:");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} - {book.Price}");
                }
            }

            if (laptops.Count > 0)
            {
                Console.WriteLine("Laptops:");
                foreach (var laptop in laptops)
                {
                    Console.WriteLine($"{laptop.Model} - {laptop.Price}");
                }
            }

            if (phones.Count > 0)
            {
                Console.WriteLine("Phones:");
                foreach (var phone in phones)
                {
                    Console.WriteLine($"{phone.Model} - {phone.Price}");
                }
            }


            if (tvs.Count > 0)
            {
                Console.WriteLine("TVs:");
                foreach (var tv in tvs)
                {
                    Console.WriteLine($"{tv.Model} - {tv.Price}");
                }
            }

            if (fridges.Count > 0)
            {
                Console.WriteLine("Fridges:");
                foreach (var fridge in fridges)
                {
                    Console.WriteLine($"{fridge.Model} - {fridge.Price}");
                }
            }
        }

        public int CalculateTotalPrice()
        { 
            return books.Sum(b => b.Price) + 
                laptops.Sum(l => l.Price) + 
                phones.Sum(p => p.Price) + 
                tvs.Sum(t => t.Price) +
                fridges.Sum(f => f.Price);
        }
    }
}

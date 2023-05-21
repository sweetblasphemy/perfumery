using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExam
{

    public class Perfumery
    {
        private string name;
        public double price;
        private List<Perfume> perfumes;

        public Perfumery(string name)
        {
            Name = name;
            perfumes = new List<Perfume>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddPerfume(Perfume perfume)
        {
            perfumes.Add(perfume);
        }

        public bool SellPerfume(Perfume perfume)
        {

            return perfumes.Remove(perfume);
        }
        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var perfume in perfumes)
            {
                totalPrice += perfume.Price;
            }
            return totalPrice;
        }

        public Perfume GetPerfumeWithHighestPrice()
        {
            Perfume highestPricePerfume = null;
            double highestPrice = double.MinValue;

            foreach (var perfume in perfumes)
            {
                if (perfume.Price > highestPrice)
                {
                    highestPrice = perfume.Price;
                    highestPricePerfume = perfume;
                }
            }

            return highestPricePerfume;
        }

        public Perfume GetPerfumeWithLowestPrice()
        {

            Perfume lowestPricePerfume = null;
            double lowestPrice = double.MaxValue;

            foreach (var perfume in perfumes)
            {
                if (perfume.Price < lowestPrice)
                {
                    lowestPrice = perfume.Price;
                    lowestPricePerfume = perfume;
                }
            }
            return lowestPricePerfume;
        }

        public void RenamePerfumery(string newName)
        {
            Name = newName;
        }

        public void SellAllPerfumes()
        {
            perfumes.Clear();
        }

        public override string ToString()
        {
            if (perfumes.Count == 0)
            {
                return $"Perfumery {Name} has no available perfumes.";
            }

            string info = $"Perfumery {Name} has {perfumes.Count} perfume/s:";
            foreach (var perfume in perfumes)
            {
                info += "\n" + perfume.ToString();
            }

            return info;
        }
    }
}
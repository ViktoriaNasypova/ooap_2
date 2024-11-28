using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2OOAP
{
    // Інтерфейс для ювелірних виробів
    public interface IJewelry
    {
        string Name { get; } // Назва прикраси
        double Weight { get; } // Вага прикраси
        double Complexity { get; } // Складність виготовлення
        double GetPrice(); // Метод для отримання ціни прикраси
    }

    // Клас для ювелірних виробів із золота
    public class GoldJewelry : IJewelry
    {
        public string Name { get; }
        public double Weight { get; }
        public double Complexity { get; }

        public GoldJewelry(string name, double weight, double complexity)
        {
            Name = name;
            Weight = weight;
            Complexity = complexity;
        }

        // Розрахунок ціни золотої прикраси
        public double GetPrice()
        {
            double basePrice = 50; // Ціна за грам золота
            return Weight * basePrice * Complexity;
        }

        public override string ToString()
        {
            return $"{Name}: {GetPrice():0.00}$"; // Форматований рядок з назвою та ціною
        }
    }

    // Клас для ювелірних виробів із срібла
    public class SilverJewelry : IJewelry
    {
        public string Name { get; }
        public double Weight { get; }
        public double Complexity { get; }

        public SilverJewelry(string name, double weight, double complexity)
        {
            Name = name;
            Weight = weight;
            Complexity = complexity;
        }

        // Розрахунок ціни срібної прикраси
        public double GetPrice()
        {
            double basePrice = 30; // Ціна за грам срібла
            return Weight * basePrice * Complexity;
        }

        public override string ToString()
        {
            return $"{Name}: {GetPrice():0.00}$"; // Форматований рядок з назвою та ціною
        }
    }

    // Інтерфейс фабрики для створення прикрас
    public interface IJewelryFactory
    {
        IJewelry CreateEarrings(); // Метод для створення сережок
        IJewelry CreateRing(); // Метод для створення кільця
        IJewelry CreateChain(); // Метод для створення ланцюжка
        IJewelry CreatePendant(); // Метод для створення кулона
        IJewelry CreateBracelet(); // Метод для створення браслета
    }

    // Реалізація фабрики для золотих прикрас
    public class GoldJewelryFactory : IJewelryFactory
    {
        public IJewelry CreateEarrings()
        {
            return new GoldJewelry("Gold Earrings", 5, 1.2);
        }

        public IJewelry CreateRing()
        {
            return new GoldJewelry("Gold Ring", 3, 1.5);
        }

        public IJewelry CreateChain()
        {
            return new GoldJewelry("Gold Chain", 10, 1.8);
        }

        public IJewelry CreatePendant()
        {
            return new GoldJewelry("Gold Pendant", 2, 1.3);
        }

        public IJewelry CreateBracelet()
        {
            return new GoldJewelry("Gold Bracelet", 7, 1.6);
        }
    }

    // Реалізація фабрики для срібних прикрас
    public class SilverJewelryFactory : IJewelryFactory
    {
        public IJewelry CreateEarrings()
        {
            return new SilverJewelry("Silver Earrings", 5, 1.2);
        }

        public IJewelry CreateRing()
        {
            return new SilverJewelry("Silver Ring", 3, 1.5);
        }

        public IJewelry CreateChain()
        {
            return new SilverJewelry("Silver Chain", 10, 1.8);
        }

        public IJewelry CreatePendant()
        {
            return new SilverJewelry("Silver Pendant", 2, 1.3);
        }

        public IJewelry CreateBracelet()
        {
            return new SilverJewelry("Silver Bracelet", 7, 1.6);
        }
    }

    // Каталог для відображення ювелірних прикрас
    public class JewelryCatalog
    {
        private readonly IJewelryFactory JewelryFactory; // Фабрика для створення прикрас

        public JewelryCatalog(IJewelryFactory jewelryFactory)
        {
            JewelryFactory = jewelryFactory;
        }

        // Метод для відображення каталогу прикрас
        public void DisplayCatalog()
        {
            var earrings = JewelryFactory.CreateEarrings();
            var ring = JewelryFactory.CreateRing();
            var chain = JewelryFactory.CreateChain();
            var pendant = JewelryFactory.CreatePendant();
            var bracelet = JewelryFactory.CreateBracelet();

            // Вивід інформації про кожну прикрасу
            Console.WriteLine(earrings.ToString());
            Console.WriteLine(ring.ToString());
            Console.WriteLine(chain.ToString());
            Console.WriteLine(pendant.ToString());
            Console.WriteLine(bracelet.ToString());
        }
    }
}

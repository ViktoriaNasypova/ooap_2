using LAB2OOAP;

public class Program
{
    public static void Main()
    {
        // Відображення каталогу золотих виробів
        Console.WriteLine("Каталог золотих виробiв:");
        JewelryCatalog goldCatalog = new JewelryCatalog(new GoldJewelryFactory()); // Ініціалізація каталогу із золотою фабрикою
        goldCatalog.DisplayCatalog(); // Виведення каталогу на консоль

        // Відображення каталогу срібних виробів
        Console.WriteLine("\nКаталог срiбних виробiв:");
        JewelryCatalog silverCatalog = new JewelryCatalog(new SilverJewelryFactory()); // Ініціалізація каталогу із срібною фабрикою
        silverCatalog.DisplayCatalog(); // Виведення каталогу на консоль
        Console.WriteLine("\n");

        // Створення ювелірного виробу із золота за допомогою патерну Builder
        JewelryBuilder goldBuilder = new GoldJewelryBuilder(); // Ініціалізація "будівельника" для золотих виробів
        JewelryDirector director = new JewelryDirector(goldBuilder); // Передача "будівельника" директору

        director.BuildJewelry(); // Побудова виробу за допомогою директора
        CustomJewelry goldJewelry = goldBuilder.Build(); // Отримання результату (готовий виріб)
        Console.WriteLine(goldJewelry); // Виведення інформації про виготовлений виріб
        Console.WriteLine("\n");

        // Створення ювелірного виробу із срібла за допомогою патерну Builder
        JewelryBuilder silverBuilder = new SilverJewelryBuilder(); // Ініціалізація "будівельника" для срібних виробів
        director = new JewelryDirector(silverBuilder); // Зміна "будівельника" у директора

        director.BuildJewelry(); // Побудова виробу за допомогою директора
        CustomJewelry silverJewelry = silverBuilder.Build(); // Отримання результату (готовий виріб)
        Console.WriteLine(silverJewelry); // Виведення інформації про виготовлений виріб
    }
}

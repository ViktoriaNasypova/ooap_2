using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2OOAP
{
    // 1. Клас CustomJewelry - представляє ювелірний виріб.
    public class CustomJewelry
    {
        public string Name { get; set; }         // Назва виробу
        public double Weight { get; set; }       // Вага виробу
        public double Complexity { get; set; }   // Складність виготовлення
        public string Metal { get; set; }        // Метал, з якого виготовлений виріб
        public string Gemstone { get; set; }     // Камінь, який використовується в виробі
        public string Design { get; set; }       // Дизайн виробу (наприклад, класичний, сучасний)

        // Переоприділений метод ToString() для зручного виведення інформації про ювелірний виріб.
        public override string ToString()
        {
            return $"Jewelry: {Name}, Metal: {Metal}, Gemstone: {Gemstone}, Design: {Design}, Weight: {Weight}, Complexity: {Complexity}";
        }
    }

    // 2. Абстрактний клас JewelryBuilder - базовий клас для створення різних ювелірних виробів.
    public abstract class JewelryBuilder
    {
        // Створюється об'єкт CustomJewelry, який буде поступово налаштовуватися.
        protected CustomJewelry _jewelry = new CustomJewelry();

        // Абстрактні методи для налаштування різних властивостей виробу.
        public abstract void SetName();           // Встановити назву
        public abstract void SetMetal();          // Встановити метал
        public abstract void SetGemstone();       // Встановити камінь
        public abstract void SetDesign();         // Встановити дизайн
        public abstract void SetWeight();         // Встановити вагу
        public abstract void SetComplexity();     // Встановити складність

        // Метод для повернення повністю побудованого виробу.
        public CustomJewelry Build()
        {
            return _jewelry;
        }
    }

    // 3. Клас GoldJewelryBuilder - конкретна реалізація будівельника для золотих виробів.
    public class GoldJewelryBuilder : JewelryBuilder
    {
        public override void SetName()
        {
            _jewelry.Name = "Gold Jewelry"; // Встановлюється назва виробу
        }

        public override void SetMetal()
        {
            _jewelry.Metal = "Gold"; // Встановлюється метал - золото
        }

        public override void SetGemstone()
        {
            _jewelry.Gemstone = "Diamond"; // Встановлюється камінь - діамант
        }

        public override void SetDesign()
        {
            _jewelry.Design = "Classic"; // Встановлюється дизайн - класичний
        }

        public override void SetWeight()
        {
            _jewelry.Weight = 10; // Встановлюється вага - 10 грамів
        }

        public override void SetComplexity()
        {
            _jewelry.Complexity = 2.0; // Встановлюється складність - 2.0
        }
    }

    // 4. Клас SilverJewelryBuilder - конкретна реалізація будівельника для срібних виробів.
    public class SilverJewelryBuilder : JewelryBuilder
    {
        public override void SetName()
        {
            _jewelry.Name = "Silver Jewelry"; // Встановлюється назва виробу
        }

        public override void SetMetal()
        {
            _jewelry.Metal = "Silver"; // Встановлюється метал - срібло
        }

        public override void SetGemstone()
        {
            _jewelry.Gemstone = "Sapphire"; // Встановлюється камінь - сапфір
        }

        public override void SetDesign()
        {
            _jewelry.Design = "Modern"; // Встановлюється дизайн - сучасний
        }

        public override void SetWeight()
        {
            _jewelry.Weight = 8; // Встановлюється вага - 8 грамів
        }

        public override void SetComplexity()
        {
            _jewelry.Complexity = 1.8; // Встановлюється складність - 1.8
        }
    }

    // 5. Клас JewelryDirector - директор, який використовує будівельника для побудови ювелірного виробу.
    public class JewelryDirector
    {
        private JewelryBuilder _builder; // Посилання на будівельника

        // Конструктор, який приймає будівельника для побудови виробу.
        public JewelryDirector(JewelryBuilder builder)
        {
            _builder = builder;
        }

        // Метод для побудови виробу за допомогою будівельника.
        public void BuildJewelry()
        {
            _builder.SetName();         // Встановлюється назва
            _builder.SetMetal();        // Встановлюється метал
            _builder.SetGemstone();     // Встановлюється камінь
            _builder.SetDesign();       // Встановлюється дизайн
            _builder.SetWeight();       // Встановлюється вага
            _builder.SetComplexity();   // Встановлюється складність
        }
    }
}

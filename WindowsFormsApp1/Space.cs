using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Space 
    {
        public static Random rand = new Random(); 

        public virtual String GetInfo()
        {                                                                                                                                                                       
            return "Я объект :3";
        }

    }

    //Класс под планеты
    public class Planet : Space
    {
        public float Radius = 0;
        public bool Atmosphere = true;
        public float Gravity = 0;
        public Bitmap Image = Properties.Resources.Planet;

        public override String GetInfo()
        {
            var str = "Я планета @_@";
            str += String.Format("\nРадиус: {0} км", this.Radius);
            str += String.Format("\nНаличине атмосферы: {0}", this.Atmosphere);
            str += String.Format("\nСила притяжения: {0} (Н*м^2)/кг^2", this.Gravity);
            return str;
        }

        public static Planet Generation()
        {
            return new Planet
            {
                Radius = rand.Next() % 10000,
                Atmosphere = rand.Next(2) == 0,
                Gravity = rand.Next() % 1000
            };
        }

       
    }
        
    public enum NameType {Mellish, Brucks, Daniel, Bennet, Eclipse}

    //Класс под кометы
    public class Comet : Space
    {
        public NameType Name = NameType.Mellish;
        public int Period = 0;
        public Bitmap Image = Properties.Resources.Comet;

        public override String GetInfo()
        {
            var str = "Я комета <3";
            str += String.Format("\nМеня зовут: " + this.Name);
            str += String.Format("\nПериод: {0} лет", this.Period);
            return str;
        }

        public static Comet Generation()
        {
            return new Comet
            {
                Name = (NameType)rand.Next(4),
                Period = rand.Next() % 100
            };
        }
    }

    public enum ColorsTypes {Yellow, Black, Blue, White}

    //Класс под звезды
    public class Star : Space
    {
        public float Density = 0;
        public ColorsTypes Color = ColorsTypes.Yellow;
        public float Temperature = 0;
        public Bitmap image = Properties.Resources.Star;

        public override String GetInfo()
        {
            var str = "Я звезда *-*";
            str += String.Format("\nПлотность: {0} кг/м3", Density);
            str += String.Format("\nЦвет: " + this.Color);
            str += String.Format("\nТемпература: {0} по Цельсию", this.Temperature);
            return str;
        }

        public static Star Generation ()
        {
            return new Star
            {
                Density = rand.Next() % 100,
                Color = (ColorsTypes)rand.Next(3),
                Temperature = -1000 + rand.Next() % 1000
            };
        }
    } 
   
}
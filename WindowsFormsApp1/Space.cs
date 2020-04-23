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
        public float Distance = rand.Next() % 100000;
        public virtual String GetInfo()
        {                                                                                                                                                                       
            return "Я объект :3";
        }
    }

    //Класс под планеты
    public class Planet : Space
    {
        public enum AtmosphereValue { есть, отсутствует, частично};
        public float Radius = 0;
        public AtmosphereValue Atmosphere = AtmosphereValue.есть;
        public float Gravity = 0;

        public override String GetInfo()
        {
            var str = "Я планета @_@";
            str += String.Format("\nРадиус: {0} км", this.Radius);
            str += String.Format("\nНаличие атмосферы: {0}", this.Atmosphere);
            str += String.Format("\nСила притяжения: {0} (Н*м^2)/кг^2", this.Gravity);
            str += String.Format("\nУдаленность от Земли: {0} км", this.Distance);
            return str;
        }

        public static Planet Generation()
        {
            return new Planet
            {
                Radius = rand.Next() % 10000,
                Atmosphere = (AtmosphereValue)rand.Next(2),
                Gravity = rand.Next() % 1000
            };
        } 
    }
        
    //Класс под кометы
    public class Comet : Space
    {
        public enum NameType { Mellish, Brucks, Daniel, Bennet, Eclipse }
        public NameType Name = NameType.Mellish;
        public int Period = 0;

        public override String GetInfo()
        {
            var str = "Я комета <3";
            str += String.Format("\nМеня зовут: " + this.Name);
            str += String.Format("\nПериод: {0} лет", this.Period);
            str += String.Format("\nУдаленность от Земли: {0} км", this.Distance);
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

    //Класс под звезды
    public class Star : Space
    {
        public enum ColorsTypes { Желтый, Черный, Синий, Белый }

        public float Density = 0;
        public ColorsTypes Color = ColorsTypes.Желтый;
        public float Temperature = 0;

        public override String GetInfo()
        {
            var str = "Я звезда *-*";
            str += String.Format("\nПлотность: {0} кг/м3", Density);
            str += String.Format("\nЦвет: " + this.Color);
            str += String.Format("\nТемпература: {0} по Цельсию", this.Temperature);
            str += String.Format("\nУдаленность от Земли: {0} км", this.Distance);
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaConsole.DB
{
    public class DataClasses
    {
        public int ID { get; set; }
        public string Virobnuk { get; set; }
        public int RAM { get; set; }
        public int HD { get; set; }
        public int YadraCount { get; set; }
        public double Price { get; set; }
        public bool isInStock { get; set; }
        public DataClasses(string virobnuk, int rAM, int hD, int yadraCount, double price, bool isInStock)
        {
            Virobnuk = virobnuk;
            RAM = rAM;
            HD = hD;
            YadraCount = yadraCount;
            Price = price;
            this.isInStock = isInStock;
        }
        public virtual double Znijka(double zn) => -1;
        public virtual string Podarok() => "";

        public override string ToString() => $"ID:{ID}; Виробник:{Virobnuk};Об'єм RAM:{RAM};Об'єм жорского диску:{HD};Кількість ядер:{YadraCount};Ціна:[{Price}]грн;";

    }
    public class PC : DataClasses
    {
        public string Model { get; set; }
        public string Korpus { get; set; }
        public PC(string virobnuk, int rAM, int hD, int yadraCount, double price, bool isInStock, string model, string korpus)
            : base(virobnuk, rAM, hD, yadraCount, price, isInStock)
        {
            Model = model;
            Korpus = korpus;
        }
        public override string Podarok() => "***}Ціна ПК перевищує 40000. Вам надано подарунок у вигляді мишки.{***";

        public override string ToString() => base.ToString() + $"Корпус:{Korpus};Модель:{Model}.";
    }
    public class LapTop : DataClasses
    {
        public double Diagonal { get; set; }
        public string Dinamics { get; set; }
        public LapTop(string virobnuk, int rAM, int hD, int yadraCount, double price, bool isInStock, double diagonal, string dinamics)
            : base(virobnuk, rAM, hD, yadraCount, price, isInStock)
        {
            Diagonal = diagonal;
            Dinamics = dinamics;
        }
        public override double Znijka(double zn) => Price -= Price * zn;
        public override string ToString() => base.ToString() + $"Діагональ:{Diagonal};Динаміки:{Dinamics}.";
    }
}

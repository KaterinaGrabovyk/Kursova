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
        public int ID { get; set; }// айді
        public string Virobnuk { get; set; }//Виробник
        public int RAM { get; set; }//RAM
        public int HD { get; set; }//жорсткий диск
        public int YadraCount { get; set; }//кількість ядер
        public double Price { get; set; }//ціня
        public bool isInStock { get; set; }//статус 
        public DataClasses(string virobnuk, int rAM, int hD, int yadraCount, double price, bool isInStock)
        {
            Virobnuk = virobnuk;
            RAM = rAM;
            HD = hD;
            YadraCount = yadraCount;
            Price = price;
            this.isInStock = isInStock;
        }
        public virtual double Znijka(double zn) => -1;//знижка
        public virtual string Podarok() => "";//подарунок

        public override string ToString() => $"ID:{ID}; Виробник:{Virobnuk};Об'єм RAM:{RAM};Об'єм жорского диску:{HD};Кількість ядер:{YadraCount};Ціна:[{Price}]грн;";//для виводу інформацї

    }
    public class PC : DataClasses
    {
        public string Model { get; set; }//модель
        public string Korpus { get; set; }//корпус
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
        public double Diagonal { get; set; }//діагональ
        public string Dinamics { get; set; }//динаміки
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

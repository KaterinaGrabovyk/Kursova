using KursovaConsole.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace KursovaConsole
{
    internal class Program
    {
        static List<PC> pcs = new List<PC>();
        static List<LapTop> lapTops = new List<LapTop>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("При першому включенні програми дії завантажуються повільно. Почекайте, доки все завантжиться після натиску.");
            M();
        }
        //Головне меню
        static void M()
        {
            Console.WriteLine("Для виконання дії введіть відповідну цифру:\n1-додати,\n2-видалити,\n3-показати,\n4-редагувати.\nІнакша відповідь буде вважатися помилкою.");
            string vidp1 = Console.ReadLine();
            switch (vidp1)
            {
                case "1": Dodati(); break;
                case "2": Vidal(); break;
                case "3":
                    Console.Clear();
                    Show();
                    break;
                case "4": Redact(); break;
                default:
                    Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                    Console.Clear();
                    M(); break;
            }
        }
        //Показ
        static void Show()
        {
            try
            {
                Console.WriteLine("Опції:\n1-всі елементи,\n2-ПК,\n3-ноутбуки,\n4-На головний екран.");
                string res = Console.ReadLine();
                pcs.Clear();
                lapTops.Clear();
                var db1 = new DDBContext();
                db1.Database.EnsureCreated();
                db1.PCs.Load();
                foreach (var pl in db1.PCs.Local.ToList()) { pcs.Add(pl); }
                var db2 = new DDBContext2();
                db2.Database.EnsureCreated();
                db2.LTs.Load();
                foreach (var pl in db2.LTs.Local.ToList()) { lapTops.Add(pl); }
                switch (res)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("-------------------------|Вся електротехніка|-------------------------");
                        foreach (var l in pcs)
                        {
                            Console.WriteLine(l);
                            Console.WriteLine("-------------------------");
                        }
                        foreach (var l in lapTops)
                        {
                            Console.WriteLine(l);
                            Console.WriteLine("-------------------------");
                        }
                        Show();
                        break;//Все
                    case "2":
                        if (pcs.IsNullOrEmpty())
                        {
                            Console.Write("Список порожній,тому неможливо виконати додаткові дії.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                            Console.Clear();
                            M();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("-------------------------|Персональні комп'ютери|-------------------------");
                            foreach (var l in pcs)
                            {
                                Console.WriteLine(l);
                                if (l.Price > 40000) { Console.WriteLine(l.Podarok()); }
                                Console.WriteLine("-------------------------");
                            }
                            Console.WriteLine("Опції:\n1-Пошук за об'ємом на диску,\n2-Сортування за ціною,\n3-Меню вибору,\n4-На головний екран.");
                            string PCOnly = Console.ReadLine();
                            switch (PCOnly)
                            {
                                case "1":
                                    Console.Write("Вкажіть об'єм диску: ");
                                    int V = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine($"-------------------------|Персональні комп'ютери HD = {V}|-------------------------");
                                    foreach (var l in pcs)
                                    {
                                        if (l.HD == V)
                                        {
                                            Console.WriteLine(l);
                                            Console.WriteLine("-------------------------");
                                        }
                                    }
                                    Show();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine($"-------------------------|Персональні комп'ютери відсортовані по ціні в порядку зростання|-------------------------");
                                    IEnumerable<PC> pcc = pcs.OrderBy(pc => pc.Price);
                                    foreach (var l in pcc) { Console.WriteLine(l); Console.WriteLine("-------------------------"); }
                                    Show();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Show();
                                    break;//Меню вибору
                                case "4":
                                    Console.Clear();
                                    M();
                                    break;//Головне меню
                                default:
                                    Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine(); Console.Clear();
                                    M(); break;
                            }
                        }
                        break;//Тільки ПК
                    case "3":
                        if (lapTops.IsNullOrEmpty())
                        {
                            Console.Write("Список порожній,тому неможливо виконати додаткові дії.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                            Console.Clear();
                            M();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("-------------------------|Ноутбуки|-------------------------");
                            foreach (var l in lapTops)
                            {
                                Console.WriteLine(l);
                                Console.WriteLine("-------------------------");
                            }
                            Console.WriteLine("Опції:\n1-Використати промокод,\n2-Показати за певними критеріями,\n3-Меню вибору,\n4-На головний екран.");
                            string LapOnly = Console.ReadLine();
                            switch (LapOnly)
                            {
                                case "1":
                                    Console.Write("Оберіть елемент, ввівши його ID: ");
                                    int id = int.Parse(Console.ReadLine());
                                    foreach (var l in lapTops)
                                    {
                                        if (l.ID == id)
                                        {
                                            Console.Write("Введіть знижку (у відсодках %): ");
                                            double ProCode = double.Parse(Console.ReadLine());
                                            Console.Clear();
                                            Console.WriteLine($"-------------------------|Ноутбук {l.ID} Зі знижкою {ProCode}%|-------------------------");
                                            ProCode = ProCode / 100;
                                            l.Znijka(ProCode);
                                            Console.WriteLine(l);
                                        }
                                        else
                                        {
                                            Console.Write("Такого елемента не знайдено. Повернення на Меню вибору - будь яка кнопка"); Console.ReadLine();
                                            Console.Clear();
                                            Show();
                                        }
                                    }
                                    Show();
                                    break;//Промокод
                                case "2":
                                    Console.WriteLine("Опції:\n1-Вибір за виробником,\n2-Наявність на складі.");
                                    string optionsLap = Console.ReadLine();
                                    switch (optionsLap)
                                    {
                                        case "1":
                                            Console.Write("Впишіть назву виробника: ");
                                            string virLap = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine($"-------------------------|Ноутбуки фірми {virLap}|-------------------------");
                                            foreach (var l in lapTops)
                                            {
                                                if (l.Virobnuk == virLap)
                                                {
                                                    Console.WriteLine(l);
                                                }
                                            }
                                            Show();
                                            break;//Виробник
                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine($"-------------------------|Ноутбуки в наявності|-------------------------");
                                            foreach (var l in lapTops)
                                            {
                                                if (l.isInStock == true) { Console.WriteLine(l); } else { Console.WriteLine($"ID={l.ID} ;відсутній."); }
                                                Console.WriteLine("-------------------------");
                                            }

                                            Show();
                                            break;//В наявності

                                        default:
                                            Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                            M(); break;
                                    }
                                    break;//Критерії
                                case "3":
                                    Console.Clear();
                                    Show();
                                    break;//Меню вибору
                                case "4":
                                    Console.Clear();
                                    M();
                                    break;//Головне меню
                                default:
                                    Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                    Console.Clear();
                                    M(); break;
                            }
                        }
                        break;//Тільки ноутбуки
                    case "4":
                        Console.Clear();
                        M();
                        break;//Головне меню
                    default:
                        Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                        Console.Clear();
                        M(); break;

                }
            }
            catch (FormatException)
            {
                Console.Write("Введено неправильний формат.Тисніть будь що, щоб повернутись в меню.");
                Console.ReadLine();
                Console.Clear();
                Show();

            }
        }
        //Додавання
        static void Dodati()
        {
            try
            {
                Console.Clear();
                Console.Write("Виробник: ");
                string Vir = Console.ReadLine();
                Console.Write("об'єм RAM: ");
                int RAM = int.Parse(Console.ReadLine());
                Console.Write("об'єм HD: ");
                int HD = int.Parse(Console.ReadLine());
                Console.Write("Кількість ядер: ");
                int YadCount = int.Parse(Console.ReadLine());
                Console.Write("Ціна: ");
                double Price = double.Parse(Console.ReadLine());
                Console.Write("Якщо в наявності, пишіть Т,якщо немає - тисніть будь яку кнопку: ");
                bool isAwaible;
                if (Console.ReadLine() == "T")
                {
                    isAwaible = true;
                }
                else
                {
                    isAwaible = false;
                }
                Console.WriteLine("Вкажіть тип.\n1 - ПК,\n2 - ноутбук");
                string res = Console.ReadLine();

                switch (res)
                {
                    case "1":
                        Console.Write("Модель: ");
                        string Model = Console.ReadLine();
                        Console.Write("Корпус: ");
                        string Korpus = Console.ReadLine();
                        var db1 = new DDBContext();
                        db1.Database.EnsureCreated();
                        db1.PCs.Load();
                        db1.Add(new PC(Vir, RAM, HD, YadCount, Price, isAwaible, Model, Korpus));
                        db1.SaveChanges();
                        foreach (var pl in db1.PCs.Local.ToList())
                        {
                            pcs.Add(pl);
                        }
                        break;
                    case "2":
                        Console.Write("Діагональ: ");
                        double Diagonal = double.Parse(Console.ReadLine());
                        Console.Write("Динаміки: ");
                        string Dinamics = Console.ReadLine();
                        var db2 = new DDBContext2();
                        db2.Database.EnsureCreated();
                        db2.LTs.Load();
                        db2.Add(new LapTop(Vir, RAM, HD, YadCount, Price, isAwaible, Diagonal, Dinamics));
                        db2.SaveChanges();
                        foreach (var pl in db2.LTs.Local.ToList())
                        {
                            lapTops.Add(pl);
                        }
                        break;
                    default:
                        Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                        Console.Clear();
                        M(); break;
                }

                Console.Clear();
                Console.WriteLine("Об'єкт додано");
                M();
            }
            catch (FormatException)
            {
                Console.Write("Введено неправильний формат.Тисніть будь що, щоб почати заново.");
                Console.ReadLine();
                Console.Clear();
                Dodati();

            }
        }
        //Видалення
        static void Vidal()
        {
            try
            {
                Console.Clear();
                pcs.Clear();
                lapTops.Clear();
                var db1 = new DDBContext();
                db1.Database.EnsureCreated();
                db1.PCs.Load();
                foreach (var pl in db1.PCs.Local.ToList()) { pcs.Add(pl); }
                var db2 = new DDBContext2();
                db2.Database.EnsureCreated();
                db2.LTs.Load();
                foreach (var pl in db2.LTs.Local.ToList()) { lapTops.Add(pl); }
                Console.WriteLine("Оберіть тип техніки.\n1-ПК,\n2-ноутбуки.");
                string res = Console.ReadLine();
                switch (res)
                {
                    case "1":
                        if (pcs.IsNullOrEmpty())
                        {
                            Console.Write("Список порожній.Дію виконати неможливо.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                            Console.Clear();
                            M();
                        }
                        else
                        {
                            foreach (var l in pcs)
                            {
                                Console.WriteLine(l);
                                Console.WriteLine("-------------------------");
                            }
                            Console.Write("Введіть ID для видалення: ");
                            int id = int.Parse(Console.ReadLine());
                            foreach (var pl in db1.PCs.Local.ToList())
                            {
                                if (pl.ID == id)
                                {
                                    db1.Remove(pl);
                                    db1.SaveChanges();
                                    break;
                                }
                                else
                                {
                                    Console.Write("Такого елемента не знайдено. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                    Console.Clear();
                                    M();
                                }
                            }
                        }

                        break;
                    case "2":
                        if (lapTops.IsNullOrEmpty())
                        {
                            Console.Write("Список порожній.Дію виконати неможливо.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                            Console.Clear();
                            M();
                        }
                        else
                        {
                            foreach (var l in lapTops)
                            {
                                Console.WriteLine(l);
                                Console.WriteLine("-------------------------");
                            }
                            Console.Write("Введіть ID для видалення: ");
                            int idi = int.Parse(Console.ReadLine());
                            foreach (var pl in db2.LTs.Local.ToList())
                            {
                                if (pl.ID == idi)
                                {
                                    db2.Remove(pl);
                                    db2.SaveChanges();
                                    break;
                                }
                                else
                                {
                                    Console.Write("Такого елемента не знайдено. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                    Console.Clear();
                                    M();
                                }
                            }
                        }
                        break;
                    default:
                        Console.Write("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                        Console.Clear();
                        M(); break;
                }
                Console.Clear();
                Console.WriteLine("Об'єкт Видалено");
                M();
            }
            catch (FormatException)
            {
                Console.Write("Введено неправильний формат.Тисніть будь що, щоб Повернутися в головне меню.");
                Console.ReadLine();
                Console.Clear();
                M();

            }
        }
        //Редагування
        static void Redact()
        {
            Console.Clear();
            pcs.Clear();
            lapTops.Clear();
            var db1 = new DDBContext();
            db1.Database.EnsureCreated();
            db1.PCs.Load();
            foreach (var pl in db1.PCs.Local.ToList()) { pcs.Add(pl); }
            var db2 = new DDBContext2();
            db2.Database.EnsureCreated();
            db2.LTs.Load();
            foreach (var pl in db2.LTs.Local.ToList()) { lapTops.Add(pl); }
            Console.WriteLine("Оберіть тип техніки.\n1-ПК,\n2-ноутбуки.");
            string res = Console.ReadLine();
            switch (res)
            {
                case "1":
                    if (pcs.IsNullOrEmpty())
                    {
                        Console.Write("Список порожній.Дію виконати неможливо.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                        Console.Clear();
                        M();
                    }
                    else
                    {
                        foreach (var l in pcs)
                        {
                            Console.WriteLine(l);
                            Console.WriteLine("-------------------------");
                        }
                        Console.Write("Введіть ID для редагування ціни: ");
                        int id = int.Parse(Console.ReadLine());
                        foreach (var pli in db1.PCs.Local.ToList())
                        {
                            if (pli.ID == id)
                            {
                                Console.WriteLine("Стара ціна: " + pli.Price);
                                break;
                            }
                            else
                            {
                                Console.Write("Такого елемента не знайдено. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                Console.Clear();
                                M();
                            }
                        }
                        Console.Write("Введіть нову ціну: ");
                        double nPPrice = double.Parse(Console.ReadLine());
                        foreach (var pli in db1.PCs.Local.ToList())
                        {
                            if (pli.ID == id)
                            {
                                pli.Price = nPPrice;
                                db1.SaveChanges();
                            }
                        }
                    }
                    break;
                case "2":
                    if (lapTops.IsNullOrEmpty())
                    {
                        Console.Write("Список порожній.Дію виконати неможливо.Тисніть будь що для повернення на головне меню."); Console.ReadLine();
                        Console.Clear();
                        M();
                    }
                    else
                    {
                        foreach (var l in lapTops)
                        {
                            Console.WriteLine(l);
                            Console.WriteLine("-------------------------");
                        }
                        Console.Write("Введіть ID для редагування ціни: ");
                        int idi = int.Parse(Console.ReadLine());
                        foreach (var pli in db2.LTs.Local.ToList())
                        {
                            if (pli.ID == idi)
                            {
                                Console.WriteLine("Стара ціна: " + pli.Price);
                                break;
                            }
                            else
                            {
                                Console.Write("Такого елемента не знайдено. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                                Console.Clear();
                                M();
                            }
                        }
                        Console.Write("Введіть нову ціну: ");
                        double nPrice = double.Parse(Console.ReadLine());
                        foreach (var pli in db2.LTs.Local.ToList())
                        {
                            if (pli.ID == idi)
                            {
                                pli.Price = nPrice;
                                db2.SaveChanges();
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Нічого не обрано/Некоректний вибір. Повернення на головне меню - будь яка кнопка"); Console.ReadLine();
                    Console.Clear();
                    M(); break;
            }
            Console.Clear();
            Console.WriteLine("Ціну змінено");
            M();
        }
    }
}

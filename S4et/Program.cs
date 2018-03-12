using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S4et
{
    class S4et
    {
        public String Name { get; set; }

        private int nomerS4eta;
        public int Num { get; set; }

        public double Summa { get; set; }

        public S4et()
        {
            this.Num = 0;
            this.nomerS4eta = 0;
            this.Summa = 0;
        }

        public void Input()
        {
            Console.Write("Введите наименование счета: "); this.Name = Console.ReadLine();
            Console.Write("Введите номер счета: "); this.nomerS4eta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сумму счета: "); this.Summa = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Наименнование: { this.Name }");
            Console.WriteLine($"Номер счета: { this.nomerS4eta }");
            Console.WriteLine($"Сумма счета: { this.Summa }");
        }

        static void Main(string[] args)
        {
            S4et scr = new S4et();
            scr.Input();
            scr.Print();
            Console.ReadKey();
        }

    }
}


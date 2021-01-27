using System;

namespace DZ_09_Properties
{
    public class Computers
    {
        public string title { get; set; }
        public string owner { get; }
        public string macAdress { get; } = "00:AB:CD:EF:11:22";
        public string ram { get; set; }
        public string cpu { get; set; }
        public string hdd { get; set; }
        public string os { get; set; }

        public Computers() 
        {
            title = "Lenovo";
            owner = "Sidoroff";
            ram = "8000";
            cpu = "518";
            hdd = "50";
            os = "Linux";
        }

        public Computers(string t, string r, string c, string h, string o) 
        { 
            title = t; 
            ram = r; 
            cpu = c; 
            hdd = h; 
            os = o; 
        }

        public void GetInfo()
        {
            Console.WriteLine(
                $"Наименование компьютера:\t{title};" +
                $"\nВладелец:\t\t\t{owner};" +
                $"\nMac адрес:\t\t\t{macAdress};" +
                $"\nОЗУ:\t\t\t\t{ram};" +
                $"\nПроцессор:\t\t\t{cpu};" +
                $"\nВинчестер:\t\t\t{hdd};" +
                $"\nОперационная система:\t\t{os}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computers  computer_1 = new Computers();
            computer_1.title = "Acer";
            computer_1.ram = "3000";
            computer_1.cpu = "327";
            computer_1.hdd = "10";
            computer_1.os = "Windows";

            Computers computer_2 = new Computers();
            computer_2.title = "Apple";
            computer_2.ram = "5000";
            computer_2.cpu = "336";
            computer_2.hdd = "20";
            computer_2.os = "MacOS";

            Computers computer_3 = new Computers();

            computer_1.GetInfo();
            Console.WriteLine("+++++++++++++++++++++++++");
            computer_2.GetInfo();
            Console.WriteLine("+++++++++++++++++++++++++");
            computer_3.GetInfo();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.Write("Введите количество экземпляров компьютеров: ");
            int countOfInstances = int.Parse(Console.ReadLine());
            Computers[] computer = new Computers[countOfInstances];
            for (int i = 0; i < countOfInstances; i++)
            {
                Console.WriteLine("+++++++++++++++++++++++++");
                Console.WriteLine($"Введите параметры компьтера {i+1}");
                Console.WriteLine();
                computer[i] = new Computers();
                Console.Write("Наименование компьютера:");
                computer[i].title = Console.ReadLine();
                Console.Write("ОЗУ:");
                computer[i].cpu = Console.ReadLine();
                Console.Write("Процессор:");
                computer[i].ram = Console.ReadLine();
                Console.Write("Винчестер:");
                computer[i].hdd = Console.ReadLine();
                Console.Write("Операционная система:");
                computer[i].os = Console.ReadLine();
            }
            for (int i = 0; i < countOfInstances; i++)
            {
                Console.WriteLine("+++++++++++++++++++++++++");
                Console.WriteLine($"\nИнформация о ваших Компьютере {i+1}\n");
                Console.WriteLine($"Наименование компьютера:{computer[i].title}");
                Console.WriteLine($"Владелец:{computer[i].owner} ");
                Console.WriteLine($"Mac адрес:{computer[i].macAdress} ");
                Console.WriteLine($"ОЗУ:{computer[i].cpu}");
                Console.WriteLine($"Процессор:{computer[i].ram}");
                Console.WriteLine($"Винчестер:{computer[i].hdd}");
                Console.WriteLine($"Операционная система:{computer[i].os}");
            }
                Console.ReadKey();
        }
    }
}

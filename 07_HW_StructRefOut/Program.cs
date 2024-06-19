using System.Text;

namespace _07_HW_StructRefOut
{
    struct date_work
    {
        public int day;
        public int month;
        public int year;
    }

    class Worker
    {
        private string lastname;
        private string inicials;
        private int age;
        private int salary;
        private date_work date_start_work;


        public Worker()
        {
            lastname = "no lastname";
            inicials = "no inicials";
            age = 0;
            salary = 0;
            date_start_work = new date_work { day = DateTime.Now.Day, month = DateTime.Now.Month, year = DateTime.Now.Year };
        }
        public Worker (string l, string i, int a, int s,date_work d)
        {
            lastname = l;
            inicials = i;
            age = a;
            salary = s;
            date_start_work = d;
        }

        public string Lastname
        { 
            get { return lastname; } 
            set { lastname = value; }
        }

        public string Inicials
        {
            get { return inicials; }
            set { inicials = value; }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18 || value > 60)
                {
                    throw new ArgumentException("Помилка: вік повинен бути між 18 та 60.");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Помилка: зарплата не може бути від'ємною");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public date_work Date_start_work
        {
            get { return date_start_work; }
            set
            {
                if (value.year > DateTime.Now.Year ||
                    (value.year == DateTime.Now.Year && value.month > DateTime.Now.Month) ||
                    (value.year == DateTime.Now.Year && value.month == DateTime.Now.Month && value.day > DateTime.Now.Day))
                {
                    throw new ArgumentException("Помилка: дата не може бути більшою за сьогоднішню.");
                }
                else
                {
                    date_start_work = value;
                }
            }
        }

        public int Staj_of_work()
        {
            return DateTime.Now.Year-date_start_work.year;
        }
        public void Print()
        {
            Console.WriteLine($"Lastname: {lastname}");
            Console.WriteLine($"Inicials: {inicials}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Date start of work: {date_start_work.day}.{date_start_work.month}.{date_start_work.year}");
            Console.WriteLine("___________________________________________");
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Worker[] mas = new Worker[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Worker();
                Console.Write("Введіть прізвище: ");
                mas[i].Lastname = Console.ReadLine();
                Console.Write("Введіть ініціали: ");
                mas[i].Inicials = Console.ReadLine();
                while (true)
                {
                    Console.Write("Введіть вік :");
                    try
                    {
                        mas[i].Age = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Помилка: " + ex.Message);
                    }
                }
                while (true)
                {
                    Console.Write("Введіть зарплату:");
                    try
                    {
                        mas[i].Salary = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Помилка: " + ex.Message);
                    }
                }
                while (true)
                {
                    Console.WriteLine("Введіть дату");
                    try
                    {
                        date_work date1;
                        Console.Write("День: ");
                        date1.day= int.Parse(Console.ReadLine());
                        Console.Write("Місяць: ");
                        date1.month= int.Parse(Console.ReadLine());
                        Console.Write("Рік: ");
                        date1.year= int.Parse(Console.ReadLine());
                        mas[i].Date_start_work = date1;
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Помилка: " + ex.Message);
                    }
                }

            }


            Console.WriteLine();
            foreach (Worker worker in mas)
            {
                worker.Print();
            }
            int max = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[max].Staj_of_work() < mas[i].Staj_of_work())
                {
                    max = i;
                }
            }
            Console.WriteLine($"Найбільший стаж роботи : {mas[max].Staj_of_work()} років у працівника з прізвищем: {mas[max].Lastname}");
        }
    }
}

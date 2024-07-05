using System.Text;

namespace _16_HW_Dictionary
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class PhoneBook
    {
        public Dictionary<string, Person> Book { get; set; }
        public StringBuilder stringBuilder { get; set; }
        public PhoneBook() { Book = new Dictionary<string, Person>(); stringBuilder = new StringBuilder(); }
        public void AddPerson(string number, Person person)
        {
            Book.Add(number, person);
        }
        public void Remove(string number)
        {
            if (Book.ContainsKey(number))
            {
                Book.Remove(number);
            }
        }
        public void Search(string number)
        {
            if (Book.ContainsKey(number))
            {
                Console.WriteLine(number + " - " + Book[number].FirstName + " " + Book[number].LastName);
            }
        }
        public void Rename(string number)
        {
            if (Book.ContainsKey(number))
            {
                Console.Write("Enter first name: ");
                Book[number].FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                Book[number].LastName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
        }
        public override string ToString()
        {

            foreach (KeyValuePair<string, Person> pair in Book)
            {
                stringBuilder.AppendLine(pair.Key + " - " + pair.Value.FirstName + " " + pair.Value.LastName);
            }
            return stringBuilder.ToString();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.AddPerson("+380XXXXXXXXX", new Person() { FirstName = "Bohdan", LastName = "Smirnov" });
            phoneBook.AddPerson("+3801122XXXXX", new Person() { FirstName = "1", LastName = "1" });
            phoneBook.AddPerson("+3802222X222X", new Person() { FirstName = "2", LastName = "2" });
            Console.WriteLine(phoneBook);
            string str = "Ось будинок, який збудував Джек.А це пшениця, яка у темній коморі зберігається у будинку, який збудував Джек.А це веселий птах-синиця, який часто краде пшеницю, яка в темній коморі зберігається у будинку, який збудував Джек.";
            Console.OutputEncoding = Encoding.UTF8;
            string[] Words = str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int num = 0;
            foreach (string word in Words)
            {
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 1);
                }
                else
                {
                    dic[word] += 1;
                }
                num++;
            }
            int index = 1;
            foreach (KeyValuePair<string, int> pair in dic)
            {
                Console.WriteLine("{0,-15}{1,-25}{2,-10}", index.ToString() + ".", pair.Key, pair.Value);
                index++;
            }
            Console.WriteLine($"Всього слів : {num}, унікальних : {dic.Count} ");
        }
    }
}



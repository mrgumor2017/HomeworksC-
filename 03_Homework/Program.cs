using System.Text;
  
namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            StringBuilder str1 = new StringBuilder();
            Console.Write("Введіть рядок : ");
            str1.Append(Console.ReadLine());

            int num1;
            while (true)
            {
                Console.Write("Введіть позицію куди вставити рядок: ");
                num1 = int.Parse(Console.ReadLine());
                if (num1 <= str1.Length && num1 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong index");
                }
            }

            string str1_1;
            Console.Write("Введіть 2 рядок : ");
            str1_1 = Console.ReadLine();
            str1.Insert(num1 - 1, str1_1);
            Console.WriteLine(str1);


            string str2;
            Console.Write("Введіть рядок : ");
            str2 = Console.ReadLine();
            char[] stringArray = str2.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.WriteLine(reversedStr);
            if (str2 == reversedStr)
            {
                Console.WriteLine("Рядок є паліндромом");
            }
            else
            {
                Console.WriteLine("Рядок не є паліндромом");
            }

            string str3;
            Console.Write("Введіть рядок : ");
            str3 = Console.ReadLine();
            char[] stringArray3 = str3.ToCharArray();
            int countUP = 0;
            int countDOWN = 0;
            foreach (char c in stringArray3)
            {
                if (char.IsUpper(c) == true)
                {
                    countUP++;
                }
                else if (char.IsLower(c) == true)
                {
                    countDOWN++;

                }
            }
            int countALL = str3.Length;
            Console.WriteLine($"Відсоток великих літер в рядку : {100 * countUP / countALL:f0}%");
            Console.WriteLine($"Відсоток малих літер в рядку : {100 * countDOWN / countALL:f0}%");



            string htmlMessage = "HTML is a standardized document markup language for viewing " +
                "web pages in a browser. Browsers receive an HTML document from the " +
                "server using HTTP/HTTPS protocols or open it from a local disk, " +
                "then interpret the code into the interface that will be displayed " +
                "on the monitor screen. ";
            string[] words = htmlMessage.Split(new char[] { ' ', ',', '.', ':', '/', ';', '?', '!', '-' },
                StringSplitOptions.RemoveEmptyEntries);
            int num4;
            Console.Write("Введіть довжину слова :");
            num4 = int.Parse(Console.ReadLine());
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == num4)
                {
                    char[] stringArray4 = words[i].ToCharArray();
                    for (int j = 0; j < 3; j++)
                    {
                        if (j < words[i].Length)
                        {
                            stringArray4[words[i].Length - 1 - j] = '$';
                        }
                    }
                    words[i] = new string(stringArray4);
                }
                Console.Write(words[i] + " | ");
            }
            Console.WriteLine();

            string htmlMessage5 = "HTML is a standardized document markup language for viewing " +
                "web pages in a browser. Browsers receive an HTML document from the " +
                "server using HTTP/HTTPS protocols or open it from a local disk, " +
                "then interpret the code into the interface that will be displayed " +
                "on the monitor screen. ";
            string[] words5 = htmlMessage5.Split(new char[] { ' ', ',', '.', ':', '/', ';', '?', '!', '-' },
                StringSplitOptions.RemoveEmptyEntries);
            int num5;
            Console.Write("Введіть номер слова :");
            num5 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine(words5[num5]);
            Console.WriteLine("Перша літера в слові :" + words5[num5][0]);


            string htmlMessage6 = "    HTML is a standardized document markup language for viewing " +
                "web pages in a browser Browsers     receive an HTML document     from the " +
                "server using      HTTP/HTTPS protocols or open it from a local disk " +
                "then interpret the code into the interface     that will be displayed " +
                "on the monitor screen    ";
            string[] words6 = htmlMessage6.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            string message = string.Join("*", words6);
            Console.WriteLine(message);



            StringBuilder builder = new StringBuilder();
            StringBuilder slovo = new StringBuilder();
            while (true)
            {
                Console.Write("Введіть слово: ");
                slovo.Clear();
                slovo.Append(Console.ReadLine());
                if (slovo[slovo.Length - 1] != '.')
                {
                    builder.Append(slovo + " ");
                }
                else
                {
                    builder.Append(slovo);
                    break;
                }
            }
            Console.WriteLine(builder);
        }
    }
}


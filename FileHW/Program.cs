using System.Text;

namespace FileHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static string ReadFile(string filePath)
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The file does not exist.");
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    byte[] readBytes = new byte[fs.Length];
                    fs.Read(readBytes, 0, readBytes.Length);
                    return Encoding.Default.GetString(readBytes);
                }
            }

            static float[] ReadMas(string filePath)
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The file does not exist.");
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    byte[] readBytes = new byte[fs.Length];
                    fs.Read(readBytes, 0, readBytes.Length);
                    string mas = Encoding.Default.GetString(readBytes);
                    string[] masStrings = mas.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    float[] masFloats = masStrings.Select(float.Parse).ToArray();

                    return masFloats;

                }
            }
            static void WriteFile(string filePath)
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Console.WriteLine("Enter the data to write to the file: ");
                    string writeText = "0";
                    while (writeText != ".")
                    {
                        writeText = Console.ReadLine();
                        if (writeText == ".")
                        {
                            break;
                        }
                        writeText += " ";
                        byte[] writeBytes = Encoding.Default.GetBytes(writeText);
                        fs.Write(writeBytes, 0, writeBytes.Length);
                    }
                    Console.WriteLine("Information recorded!");
                }
            }

            static void Generator4()
            {
                using (FileStream fs = new FileStream("parni.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (FileStream fs2 = new FileStream("neparni.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        int a;
                        int parni = 0;
                        int neparni = 0;
                        for (int i = 0; i < 10000; i++)
                        {
                            a = new Random().Next(0, 1000);
                            if (a % 2 == 0)
                            {
                                byte[] writeBytes = Encoding.Default.GetBytes(a.ToString() + " ");
                                fs.Write(writeBytes, 0, writeBytes.Length);
                                parni++;
                            }
                            else
                            {
                                byte[] writeBytes = Encoding.Default.GetBytes(a.ToString() + " ");
                                fs2.Write(writeBytes, 0, writeBytes.Length);
                                neparni++;
                            }
                        }
                        Console.WriteLine("Information recorded!");
                        Console.WriteLine("Count parni : " + parni);
                        Console.WriteLine("Count neparni : " + neparni);

                    }
                }
            }
            try
            {
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\test.txt";
                Console.WriteLine($"\nData read from the file: {ReadFile(filePath)}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
            }
            WriteFile("Test2.txt");
            Console.WriteLine(ReadFile("Test2.txt"));

            float[] mas = ReadMas("Test2.txt");
            foreach (float f in mas)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();
            Generator4();


            string readPath = @"read.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string[] masStrings = text.Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Enter word: ");
            string slovo = Console.ReadLine();
            int count = 0;
            int count2 = 0;
            static string ReverseString(string input)
            {
                return new string(input.Reverse().ToArray());
            }
            for (int i = 0; i < masStrings.Length; i++)
            {
                string reversedWord = ReverseString(masStrings[i]);
                if (slovo == masStrings[i])
                {
                    Console.WriteLine("Word was found at index " + i);
                    count++;
                }
                else if (slovo == reversedWord)
                {
                    Console.WriteLine("Reversed word was found at index " + i);
                    count2++;
                }
            }
            Console.WriteLine("Count words = " + count);
            Console.WriteLine("Count reversed words = " + count2);
            try
            {
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int countRechen = 0;
            int countUpper = 0;
            int countDown = 0;
            int countPrigolos = 0;
            int countNumber = 0;
            char[] consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    countRechen++;
                }
                else if (text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9' || text[i] == '0')
                {
                    countNumber++;
                }
                else
                {
                    {
                        if (Char.IsUpper(text[i]))
                        {
                            countUpper++;
                        }
                        else if (Char.IsLower(text[i]))
                        {
                            countDown++;
                        }
                        if (consonants.Contains(text[i]))
                        {
                            countPrigolos++;
                        }
                    }
                }

            }
            Console.WriteLine($"Number of sentences: {countRechen}");
            Console.WriteLine($"Number of upper letters: {countUpper}");
            Console.WriteLine($"Number of down letters: {countDown}");
            Console.WriteLine($"Number of numbers: {countNumber}");
            Console.WriteLine($"Number of prigolosnih letters: {countPrigolos}");
        }
    }
}



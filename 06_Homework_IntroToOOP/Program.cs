using System.Text;

namespace _06_Homework_IntroToOOP
{
    partial class Freezer
    {
        private string model;
        private float height;
        private float width;
        private float length;
        private float weight;


        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value < 0) height = Math.Abs(value);
                else height = value;
            }
        }
        public float Width
        {
            get { return width; }
            set
            {
                if (value < 0) width = Math.Abs(value);
                else width = value;
            }
        }

        static int count;
        static string brand;

        static Freezer()
        {
            count = 0;
            brand = "Samsung";
        }

        public Freezer() : this("no model", 0, 0, 0, 0) {}

        public Freezer(string model, float height, float width, float length)
        {
            Model = model;
            Height = height;
            Width = width;
            this.length = length;
            count++;
        }
        public Freezer(string model, float height, float width, float length, float weight):this(model, height, width, length)
        {
            this.weight = weight;
            count++;
        }

        
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Freezer f  = new Freezer();
            f.Print();

            string model;
            float height; 
            float width;

            Freezer[] mas = new Freezer[5];

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("Введіть модель :");
                model =Console.ReadLine();
                Console.Write("Введіть висоту :");
                height = float.Parse(Console.ReadLine());
                Console.Write("Введіть ширину :");
                width = float.Parse(Console.ReadLine());
                mas[i] = new Freezer(model, height, width, 10, 10);
               
            }

            foreach (Freezer freezer in mas)
            {
                freezer.Print();
            }
        }
    }
}

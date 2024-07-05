namespace _13_HW_Delegats
{
    
    public delegate int IntDelegate(double value);

    public delegate void SetStringDelegate(string value);

    public delegate double DoubleDelegate();

    public delegate void VoidDelegate();

    class Massive
    {

        private int[] array;
        private int size;

        public Massive()
        {
            size = 0;
            array = new int[size];
        }
        public Massive(int[] array)
        {
            this.array = array;
            size = array.Length;
        }
        public Massive(int size)
        {
            this.size = size;
            array = new int[size];
        }
        public int[] Array
        {
            get { return array; }
            set { array = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public void RandomArr()
        {
            for (int i = 0; i < size; i++)
            {
                array[i]=(int)new Random().Next(-100, 100);
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public int CountNegative()
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item < 0) {  count++; }
            }
            return count;
        }

        public int Suma()
        {
            int suma = 0;
            foreach (int item in array)
            {
                suma += item;
            }
            return suma;
        }
        public int CountPrime()
        {
            int count = 0;
            foreach (int item in array)
            {
                if (IsPrime(item)) { count++; }
            }
            return count;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

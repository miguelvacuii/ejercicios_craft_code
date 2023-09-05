using Modulo1.Ejercicio6;

namespace Modulo1.Ejercicio6
{
    class IntegerData
    {
        private int[] data = new int[5];
        private int max = 0;

        public void Add(int x)
        {
            data[max] = x;
            max++;
        }

        public int Remove()
        {
            max--;
            return data[max];
        }
    }

    class StringData
    {
        private string[] data = new string[5];
        private int max = 0;

        public void Add(string x)
        {
            data[max] = x;
            max++;
        }

        public string Remove()
        {
            max--;
            return data[max];
        }
    }


    class GenericProgram
    {
        public static void Main()
        {
            IntegerData data1 = new IntegerData();
            data1.Add(1);
            data1.Add(2);
            Console.WriteLine(data1.Remove());

            StringData data2 = new StringData();
            data2.Add("agus");
            data2.Add("ruben");
            Console.WriteLine(data2.Remove());
        }
    }
}
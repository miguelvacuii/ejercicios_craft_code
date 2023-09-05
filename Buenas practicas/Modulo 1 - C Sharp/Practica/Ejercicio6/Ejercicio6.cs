using Internal;
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

    // Creamos un genérico que sirva para todos los tipos de datos
    class GenericData<T>
    {
        private T[] data = new T[];
        private int max = 0;

        public void Add(T x)
        {
            data[max] = x;
            max++;
        }

        public T Remove()
        {
            max--;
            return data[max];
        }
    }

    // Creamos estructuras de datos de tipo lista y diccionario
    class GenericProgramRefactor
    {
        public static void Main()
        {
            IntegerData integerData = new GenericData();
            integerData.Add(1);
            integerData.Add(2);
            Console.WriteLine(integerData.Remove());

            StringData stringData = new GenericData();
            stringData.Add("hola");
            stringData.Add("adios");
            Console.WriteLine(stringData.Remove());

            UserData userData = new GenericData();
            userData.Add("Miguel", 1234);
            userData.Add("Susana", 5678);
            Console.WriteLine(userData.Remove());
        }
    }
}
using System;
using System.Collections.Generic;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string value1 = "Hola";
            // Qué voy a buscar, Por qué lo voy a remplazar
            // Remplazar las "a" por un "4"
            string value2 = value1.Replace("a", "4");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("o", "0");
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            
            Console.WriteLine("-----");

            value1 = "Hola Mundo";
            value2 = value1.Replace("Mundo", "Alumnos");
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "474+621";
            string[] value2array = value1.Split("+");
            Console.WriteLine(value1);
            // Se muestra como System.String[]
            // Console.WriteLine(value2array);

            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "474+621+56+21+457";
            value2array = value1.Split("+");

            Console.WriteLine(value1);
            Console.WriteLine("El resultado del split tiene " + value2array.Length + " strings");
            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-----");

            value1 = "fresa mora frambuesa";
            value2array = value1.Split(" ");
            Console.WriteLine(value1);
            foreach(string value in value2array)
            {
                Console.WriteLine(value);
            }

            MostrarEjemploSplit("fresa mora frambuesa", "m");
            MostrarEjemploSplit("fresa  mora frambuesa", " ");
            MostrarEjemploSplit("fresa  mora frambuesa".Replace("  ", " "), " ");

            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22", "+");
            // Replace(" ", "") -> Borrar espacios
            MostrarEjemploSplit("1 +4 + 6 +3+5 + 22".Replace(" ", ""), "+");

            MostrarEjemploSplit("fresa mora frambuesa", "mora");

            Console.WriteLine("-----");

            value1 = " fresa ";
            value2 = value1.Trim();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToLower();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, jOHN";
            value2 = value1.ToUpper();
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Peter, Albert, John";
            // value2 = value1.Reverse();
            // Convertir string a char[]
            char[] charArray = value1.ToCharArray();
            // Invertir (reverse) el array
            Array.Reverse( charArray );
            // Crear un nuevo string a partir del char[]
            value2 = new string( charArray );
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.WriteLine("-----");

            value1 = "Hola Mundo!";
            string substring1 = value1.Substring(0, 4);
            string substring2 = value1.Substring(2, 4);
            string substring3 = value1.Substring(8, 3);
            int indexOf = value1.IndexOf("M");
            int indexOf2 = value1.IndexOf("o");
            int lastIndexOf = value1.LastIndexOf("o");
            Console.WriteLine(value1);
            Console.WriteLine(substring1);
            Console.WriteLine(substring2);
            Console.WriteLine(substring3);
            Console.WriteLine("indexOf: " + indexOf);
            Console.WriteLine("indexOf2: " + indexOf2);
            Console.WriteLine("lastIndexOf: " + lastIndexOf);

            Console.WriteLine("-----");

            List<string> nombres = new List<string>();
            nombres.Add("Peter");
            nombres.Add("Albert");
            nombres.Add("Jhon");

            Console.WriteLine("Peter? " + nombres.Contains("Peter")); //true
            Console.WriteLine("bert, Jo? " + nombres.Contains("bert, Jo")); //false
            if (nombres.Contains("peter"))
            {
                //hacer algo en caso de que si lo contenga
            }

            Console.WriteLine("-----");

            value1 = "Peter, Albert, John";

            Console.WriteLine("Peter " + value1.Contains("Peter")); //true
            Console.WriteLine("bert, Jo? " + value1.Contains("bert, Jo")); //true
            Console.WriteLine("peter? " + value1.Contains("peter")); //false
            Console.WriteLine("peter? " + value1.ToLower().Contains("peter")); //true

            Console.WriteLine("-----");

            value1 = "Peter, Albert, John";
            // "Peter, Albert, John" -> "John, Albert, Peter"
            // 1) Separar en palabras
            // 2) Invertir orden de palabras
            value2array = value1.Split(", "); //["Peter", "Albert", "John"]
            // value2array.Reverse() no existe!
            Array.Reverse(value2array); //["John", "Albert", "Peter"]
            foreach (string val in value2array)
            {
                Console.WriteLine(val);
            }
            // Utilizando este separador, junta el siguiente array
            value2 = string.Join(", ", value2array);
            Console.WriteLine(value2);

             Console.WriteLine("-----");

            value1 = "John";
            value2 = value1.ToLower();
            // "John" -> "john"

            // Diagonal inversa (escapar caracteres) transforma caracteres especiales
            // en caracteres normales
            Console.WriteLine("\"John\" -> \"john\"");
            // Indicamos posición de las variables, y después pasamos sus valores
            Console.WriteLine("\"{0}\" -> \"{1}\"", value1, value2);
            // Indicamos exactamente la posición en donde van las variables
            // Nota: requiere un signo $ antes del string
            Console.WriteLine($"\"{value1}\" -> \"{value2}\"");
        }

        // public -> accesible desde cualquier archivo
        // static -> se puede mandar a llamar desde otro método static (en este caso, el Main)
        // void -> no devuelve nada (solamente imprime información en la consola)
        public static void MostrarEjemploSplit(string valor, string separador)
        {
            Console.WriteLine("-----");
            string[] valorArray = valor.Split(separador);
            Console.WriteLine(valor);
            Console.WriteLine("El resultado del split tiene " + valorArray.Length + " strings");
            foreach(string val in valorArray)
            {
                Console.WriteLine(val);
            }
        }
    }
}

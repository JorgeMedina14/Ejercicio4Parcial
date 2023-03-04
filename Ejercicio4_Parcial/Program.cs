namespace Ejercicio4_Parcial
{
    internal class Program
    {
        static string operacion = "suma";
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora(Operacion.suma, 2, 2));
            Console.WriteLine(Calculadora(Operacion.resta, 3, 3));
            Console.WriteLine(Calculadora(Operacion.multi, 2, 1));
            Console.WriteLine(Calculadora(Operacion.divi, 4, 3));
            Console.WriteLine(Calculadora(Operacion.divi, 2, 0));
            Console.ReadLine();
        }
        public enum Operacion { suma, resta, multi, divi }

        public static double Calculadora(Operacion op, double num1, double num2)
        {
            try
            {
                switch (op)
                {
                    case Operacion.suma:
                        return num1 + num2;
                    case Operacion.resta:
                        return num1 - num2;
                    case Operacion.multi:
                        return num1 * num2;
                    case Operacion.divi:
                        return num2 == 0 ? -1 : num1 / num2;
                    default:
                        Console.WriteLine("Operación inválida.");
                        return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return 0;
            }
        }
    }
        }

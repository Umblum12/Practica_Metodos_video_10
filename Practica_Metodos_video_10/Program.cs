namespace Practica_Metodos_video_10
{
    class program
    {
        static void Main(string[] args)
        {
            sumaNumeros(10,9);
            Console.ReadKey(true);
        }


        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los números es: {num1+num2}");
        }
    }
}


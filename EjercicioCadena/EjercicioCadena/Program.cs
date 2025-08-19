namespace EjercicioCadena
{
    public class Program
    {
        string cadena = "1,2";
        static void Main()
        {

        }

        public int Suma(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena))
                return 0;

            var numeros = cadena.Split(',');

            return numeros.Sum(n => int.Parse(n));
        }
    }       
}
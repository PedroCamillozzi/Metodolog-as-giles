namespace TestEjercicioCadenas
{
    [TestClass]
    public sealed class TestEjercicoCadena
    {
        [TestMethod]
        public void LongitudCorrectaTrue()
        {
            string cadena = "1,2";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Length >= 0 && cadena.Length <= 3;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void LongitudCorrectaFalse()
        {
            string cadena = "1,2,3";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Length >= 0 && cadena.Length <= 3;

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void NumerosSeparadosPorComaTrue()
        {
            string cadena = "1,2";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Contains(",");

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void NumerosSeparadosPorComaFalse()
        {
            string cadena = "1-2";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Contains(",");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EnterosTrue()
        {
            string cadena = "1,2";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Split(',').All(x => int.TryParse(x, out _));

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EnterosFalse()
        {
            string cadena = "a,b";
            var calc = new EjercicioCadena.Program();

            bool resultado = cadena.Split(',').All(x => int.TryParse(x, out _));

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void SumaCorrectaTrue()
        {
            string cadena = "1,2";
            var calc = new EjercicioCadena.Program();

            bool resultado = calc.Suma(cadena) == 3;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void SumaCorrectaFalse()
        {
            string cadena = "1,2";
            var calc = new EjercicioCadena.Program();

            bool resultado = calc.Suma(cadena) == 4;

            Assert.IsFalse(resultado);
        }
    }
}

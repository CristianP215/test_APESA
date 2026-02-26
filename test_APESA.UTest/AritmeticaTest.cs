using Microsoft.AspNetCore.Mvc;
using test_APESA.WebService.Controllers;

namespace test_APESA.UTest
{
    [TestFixture]
    public class AritmeticaTest
    {
        private AritmeticaController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new AritmeticaController();
        }

        [TearDown]
        public void Cleanup()
        {
            _controller?.Dispose();
        }

        [Test]
        public void GetSumar_DosNumerosPositivos_RetornaSumaCorrecta()
        {
            // Arrange
            int num1 = 5;
            int num2 = 7;
            int resval = 12;

            // Act
            var resultado = _controller.GetSumar(num1, num2) as OkObjectResult;

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(resval, resultado.Value);
        }

        [Test]
        public void GetSumar_NumeroNegativo_RetornaSumaCorrecta()
        {
            // Arrange
            var controller = new AritmeticaController();
            int num1 = -3;
            int num2 = 10;
            int resval = 7;

            // Act
            var resultado = controller.GetSumar(num1, num2) as OkObjectResult;

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreEqual(resval, resultado.Value);
        }

    }
}

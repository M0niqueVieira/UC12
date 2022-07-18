using Projeto_teste;
namespace TestMSTest
{
    [TestClass] 
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2; // resultado

            // Act - A��o
            var resultado = operacoes.Somar(pNum, sNum);

            // Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);

        }

        [DataTestMethod]//Loop
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        { 
            var resultado = operacoes.Somar(pNum, sNum);

            Assert.AreEqual(rNum, resultado);
        }
        [TestMethod]
        public void SubtrairDoisNumeros()
        {
            //arrange - prepara��o
            double pNum = 2;
            double sNum = 1;
            double rNum = 1;

            //act - a�ao
            var resultado = operacoes.Subtrair(pNum, sNum);

            //assert - verificacao
            Assert.AreEqual(rNum, resultado);

        }
        [DataTestMethod]//Loop
        [DataRow(5, 2, 3)]
        [DataRow(2, 5, 3)]
        [DataRow(3, 3, 0)]

        public void SubtrairDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //act - a��o
            var resultado = operacoes.Subtrair(pNum, sNum);

            //Assert - Verifica��o
            Assert.AreEqual(rNum, resultado);
        }

    }
}
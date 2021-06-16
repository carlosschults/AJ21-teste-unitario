using DemoTesteUnitario.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTesteUnitario.Test
{
    class DistanciaTest
    {
        [Test]
        public void Mais_DistanciaEmMetrosMaisDistanciaEmKm_ResultadoCorreto()
        {
            Distancia metros =
                Distancia.EmMetros(500);

            Distancia km =
                Distancia.EmQuilometros(1);

            Distancia soma = metros.Mais(km);

            Distancia resultadoEsperado =
                Distancia.EmMetros(1500);

            Assert.AreEqual(
                resultadoEsperado,
                soma);

        }

        [Test]
        public void Mais_DoisObjetosEmMetros_ResultadoCorreto()
        {
            var a = Distancia.EmMetros(5);
            var b = Distancia.EmMetros(5);

            Assert.AreEqual(
                Distancia.EmMetros(10),
                a + b);
        }

        [Test]
        public void Menos_DoisObjetosEmMetros_ResultadoCorreto()
        {
            // Arrange
            var a = Distancia.EmMetros(14);
            var b = Distancia.EmMetros(4);
            var esperado = Distancia.EmMetros(10);

            // Act
            var obtido = a.Menos(b);

            // Assert
            Assert.AreEqual(esperado, obtido);
        }

        [Test]
        public void EmMetros_NumeroNegativoComoArgumento_DisparaExcecao()
        {
            Assert.Throws<ArgumentException>(
                () => Distancia.EmMetros(-5));
        }
    }    
}

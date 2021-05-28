using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronesCsharp;
using System;

namespace TestSingleton
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Objetivo: comprobar que la clase estudiante tenga una sola instancia

            Estudiante e1 = Estudiante.ObtenerInstancia();
            Estudiante e2 = Estudiante.ObtenerInstancia();
            Estudiante e3 = Estudiante.ObtenerInstancia();

            Ejemplo clase1 = new Ejemplo();
            Ejemplo clase2 = new Ejemplo();


           // Assert.AreSame(e3, e1);
            Assert.IsInstanceOfType(clase1,typeof(Estudiante));

        }
    }
}

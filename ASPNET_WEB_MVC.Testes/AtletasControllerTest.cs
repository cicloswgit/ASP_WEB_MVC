using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASPNET_WEB_MVC.Controllers;
using ASPNET_WEB_MVC.Models;

namespace ASPNET_WEB_MVC.Testes
{
    [TestClass]
    public class AtletasControllerTest
    {
        
        [TestMethod]
        public void DetalharAtletaIDInvalido()
        {
            AtletasController Controller = new AtletasController();
         
            var Resultado = Controller.DetalharAtleta(0);

            Assert.IsTrue(Resultado != null);
        }

        [TestMethod]
        public void DetalharAtletaIDInvalido2()
        {
            AtletasController Controller = new AtletasController();

            var Resultado = Controller.DetalharAtleta(0);

            Assert.IsTrue(Resultado != null);
        }

        [TestMethod]
        public void DetalharAtletaIDInvalido3()
        {
            AtletasController Controller = new AtletasController();

            var Resultado = Controller.DetalharAtleta(0);

            Assert.IsTrue(Resultado != null);
        }
    }
}

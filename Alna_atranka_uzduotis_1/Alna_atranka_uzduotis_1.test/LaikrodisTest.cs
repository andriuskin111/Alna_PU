using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alna_atranka_uzduotis_1.test
{
    [TestClass]
    public class LaikrodisTest
    {
        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiMinDaugiauUzValKampasMaziauUz180()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(1, 10);
            // Assert
            Assert.AreEqual(laipsniai, 25);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiValDaugiauUzMinKampasMaziauUz180()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(18, 11);
            // Assert
            Assert.AreEqual(laipsniai, 119.5);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiMinDaugiauUzValKaiKampasDaugiauUz180()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(13, 55);
            // Assert
            Assert.AreEqual(laipsniai, 87.5);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiValDaugiauUzMinKaiKampasDaugiauUz180()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(22, 10);
            // Assert
            Assert.AreEqual(laipsniai, 115);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiVal_12_Min_0()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(12, 0);
            // Assert
            Assert.AreEqual(laipsniai, 0);
        }

        [TestMethod]
        public void TestuojamArTeisingaiPaskaiciuojaLaipsniusTarpRodykliuKaiVal_0_Min_0()
        {
            // Arrange
            var laikrodis = new Laikrodis();
            // Act
            double laipsniai = laikrodis.PaskaiciuotiMazesnijiKampaTarpRodykliu(0, 0);
            // Assert
            Assert.AreEqual(laipsniai, 0);
        }

    }
}

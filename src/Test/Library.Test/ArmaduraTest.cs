using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class ArmaduraTest
    {
        private Armadura armadura;
        [SetUp]
        public void Setup()
        {
            this.armadura = new Armadura(0,20);
        }

        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.armadura.Ataque = 30;
            Assert.AreEqual(this.armadura.Ataque, 30);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.armadura.Ataque = -10;
            Assert.AreEqual(this.armadura.Ataque, 0);
        }
        /*
            Es necesario probar la asignacion de una defensa valida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaValida()
        {
            this.armadura.Defensa = 50;
            Assert.AreEqual(this.armadura.Defensa, 50);
        }
        /*
            Es necesario probar la asignacion de una defensa invalida para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarDefensaNegativa()
        {
            this.armadura.Defensa = -20;
            Assert.AreEqual(this.armadura.Defensa, 0);
        }
    }


}


using NUnit.Framework;
using Roleplay_Prog;
using Roleplay_Prog.Library;

namespace Test.Library
{


    public class SpellTest
    {

        private Spell spell;
        [SetUp]
        public void Setup()
        {
            this.spell = new Spell(30);
        }

        /*
            Es necesario probar la asignacion de un ataque valido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueValido()
        {
            this.spell.Ataque = 10;
            Assert.AreEqual(this.spell.Ataque, 10);
        }
        /*
            Es necesario probar la asignacion de un ataque invalido para
            poder confirmar que el setter funciona correctamente
        */
        [Test]
        public void AsignarAtaqueNegativo()
        {
            this.spell.Ataque = -10;
            Assert.AreEqual(this.spell.Ataque, 0);
        }
    }
}
using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class GiantTest
    {

        private Giant ogro;
        private Wizard wizard;
        private Spell shoot;
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            wizard = new Wizard("Mago de Fuego");
            shoot = new Spell("Bola de fuego", 80, 0);
            wizard.SpellsBook.AddSpell(shoot);
        }

        [Test]
        public void TestReceiveAttack_ValidAttackDamage()
        {
            int initialHealth = ogro.Health + ogro.GetTotalDefense();
            ogro.ReceiveAttack(wizard.GetTotalAttack());
            Assert.That(ogro.Health, Is.EqualTo(initialHealth - wizard.GetTotalAttack()));
        }

        [Test]
        public void TestCure()
        {
            int initialHealth = ogro.Health;
            ogro.ReceiveAttack(ogro.GetTotalAttack());
            ogro.Cure();
            Assert.That(ogro.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestAddItem_ValidItem()
        {
            ogro.AddItem(new Item("Gloves", 0, 20));
            Assert.That(ogro.Equipment, Has.Exactly(1).Items);
        }

        [Test]
        public void TestRemoveItem_ValidItem()
        {
            Item item = new Item("Shield", 0, 50);
            ogro.AddItem(item);
            ogro.RemoveItem(item);
            Assert.That(ogro.Equipment, Has.Exactly(0).Items);
        }

        [Test]
        public void TestGetTotalAttack()
        {
            Assert.That(ogro.GetTotalAttack(), Is.EqualTo(100));
        }
        [Test]
        public void TestGetTotalDefense()
        {
            Assert.That(ogro.GetTotalDefense(), Is.EqualTo(0));

        }
    }
}
using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ElvesTest
    {

        private Giant ogro;
        private Elves elfo;
        private Spell shoot;
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            elfo = new Elves("Elfo");
            shoot = new Spell("Disparo magico", 40, 0);
            elfo.SpellsBook.AddSpell(shoot);
        }

        [Test]
        public void TestReceiveAttack_ValidAttackDamage()
        {
            int initialHealth = elfo.Health + elfo.GetTotalDefense();
            elfo.ReceiveAttack(ogro.GetTotalAttack());
            Assert.That(elfo.Health, Is.EqualTo(initialHealth - ogro.GetTotalAttack()));
        }

        [Test]
        public void TestReceiveAttack_AttackDamageLowerThanHealth()
        {
            int initialHealth = elfo.Health;
            elfo.ReceiveAttack(1);
            Assert.That(elfo.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestCure()
        {
            int initialHealth = elfo.Health;
            elfo.ReceiveAttack(ogro.GetTotalAttack());
            elfo.Cure();
            Assert.That(elfo.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestAddItem_ValidItem()
        {
            elfo.AddItem(new Item("Bow", 20, 0));
            Assert.That(elfo.Equipment, Has.Exactly(2).Items);
        }

        [Test]
        public void TestRemoveItem_ValidItem()
        {
            Item item = new Item("Bow", 20, 0);
            elfo.AddItem(item);
            elfo.RemoveItem(item);
            Assert.That(elfo.Equipment, Has.Exactly(1).Items);
        }

        [Test]
        public void TestGetTotalAttack()
        {
            Assert.That(elfo.GetTotalAttack(), Is.EqualTo(120));
        }
        [Test]
        public void TestGetTotalDefense()
        {
            Assert.That(elfo.GetTotalDefense(), Is.EqualTo(20));

        }
    }
}
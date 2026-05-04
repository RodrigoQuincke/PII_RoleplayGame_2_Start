using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class WizardTest
    {

        private Giant ogro;
        private Wizard wizard;
        private Elves elfo;
        private Spell shoot;
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            wizard = new Wizard("Mago");
            shoot = new Spell("Bola de fuego", 80, 0);
            elfo = new Elves("elfo");
            wizard.SpellsBook.AddSpell(shoot);
        }

        [Test]
        public void TestReceiveAttack_ValidAttackDamage()
        {
            int initialHealth = wizard.Health + wizard.GetTotalDefense();
            wizard.ReceiveAttack(ogro);
            Assert.That(wizard.Health, Is.EqualTo(initialHealth - ogro.GetTotalAttack()));
        }

        [Test]
        public void TestReceiveAttack_AttackDamageLowerThanDefense()
        {
            int initialHealth = wizard.Health;
            wizard.ReceiveAttack(elfo);
            Assert.That(wizard.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestCure_AfterDamage_RestoresInitialHealth()
        {
            int initialHealth = wizard.Health;
            wizard.ReceiveAttack(ogro);
            wizard.Cure();
            Assert.That(wizard.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        public void TestAddItem_ValidItem()
        {
            wizard.AddItem(new Shield("Shield", 20));
            Assert.That(wizard.Equipment, Has.Exactly(2).Items);
        }

        [Test]
        public void TestRemoveItem_ValidItem()
        {
            IItem item = new Shield("Shield", 20);
            wizard.AddItem(item);
            wizard.RemoveItem(item);
            Assert.That(wizard.Equipment, Has.Exactly(1).Items);
        }

        [Test]
        public void TestGetTotalAttack()
        {
            Assert.That(wizard.GetTotalAttack(), Is.EqualTo(160));
        }
        [Test]
        public void TestGetTotalDefense()
        {
            Assert.That(wizard.GetTotalDefense(), Is.EqualTo(80));

        }
    }
}
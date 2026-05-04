using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class KnightTest
    {

        private Giant ogro;
        private Knight knight;
        private Spell shoot;
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            knight = new Knight("Caballero");
        }

        [Test]
        // El daño recibido es el ataque del caballero menos la defensa del caballero
        public void TestReceiveAttack_ValidAttackDamage_ReducesHealth()
        {
            int initialHealth = knight.Health + knight.GetTotalDefense();
            knight.ReceiveAttack(knight);
            Assert.That(knight.Health, Is.EqualTo(initialHealth - knight.GetTotalAttack()));
        }

        [Test]
        // Un ataque menor o igual a la defensa no reduce la vida
        public void TestReceiveAttack_AttackDamageLowerThanDefense_HealthUnchanged()
        {
            IItem helmet = new Armor("armadura", 100);
            knight.AddItem(helmet);
            int initialHealth = knight.Health;
            knight.ReceiveAttack(ogro);
            Assert.That(knight.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        // Curar restaura la vida inicial
        public void TestCure_AfterDamage_RestoresInitialHealth()
        {
            int initialHealth = knight.Health;
            knight.ReceiveAttack(ogro);
            knight.Cure();
            Assert.That(knight.Health, Is.EqualTo(initialHealth));
        }

        [Test]
        // Agregar un item incrementa la lista de equipamiento
        public void TestAddItem_ValidItem_IncreasesEquipmentCount()
        {
            knight.AddItem(new Sword("sword2", 10));
            Assert.That(knight.Equipment, Has.Exactly(4).Items);
        }

        [Test]
        // Quitar un item reduce la lista de equipamiento
        public void TestRemoveItem_ExistingItem_DecreasesEquipmentCount()
        {
            IItem sword2 = new Sword("sword2", 10);
            knight.AddItem(sword2);
            knight.RemoveItem(sword2);
            Assert.That(knight.Equipment, Has.Exactly(3).Items);
        }

        [Test]
        // Ataque base (90) + Bow (40) = 130
        public void TestGetTotalAttack_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(knight.GetTotalAttack(), Is.EqualTo(200));
        }
        [Test]
        // Defensa base (30) + Armor (50) = 80
        public void TestGetTotalDefense_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(knight.GetTotalDefense(), Is.EqualTo(170));

        }
    }
}
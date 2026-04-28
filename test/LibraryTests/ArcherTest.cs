using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
        public class ArcherTest
    {
        private Giant ogro;
        private Archer archer;
 
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            archer = new Archer("Arquero");
        }
 
        [Test]
        // El daño recibido es el ataque del gigante menos la defensa del arquero
        public void TestReceiveAttack_ValidAttackDamage_ReducesHealth()
        {
            int initialHealth = archer.Health + archer.GetTotalDefense();
            archer.ReceiveAttack(ogro);
            Assert.That(archer.Health, Is.EqualTo(initialHealth - ogro.GetTotalAttack()));
        }
 
        [Test]
        // Un ataque menor o igual a la defensa no reduce la vida
        public void TestReceiveAttack_AttackDamageLowerThanDefense_HealthUnchanged()
        {
            IItem helmet = new Helmet("casco", 100);
            archer.AddItem(helmet);
            int initialHealth = archer.Health;
            archer.ReceiveAttack(ogro);
            Assert.That(archer.Health, Is.EqualTo(initialHealth));
        }
 
        [Test]
        // Curar restaura la vida inicial
        public void TestCure_AfterDamage_RestoresInitialHealth()
        {
            int initialHealth = archer.Health;
            archer.ReceiveAttack(ogro);
            archer.Cure();
            Assert.That(archer.Health, Is.EqualTo(initialHealth));
        }
 
        [Test]
        // Agregar un item incrementa la lista de equipamiento
        public void TestAddItem_ValidItem_IncreasesEquipmentCount()
        {
            archer.AddItem(new Bow("bow2", 10));
            Assert.That(archer.Equipment, Has.Exactly(3).Items);
        }
 
        [Test]
        // Quitar un item reduce la lista de equipamiento
        public void TestRemoveItem_ExistingItem_DecreasesEquipmentCount()
        {
            IItem bow2 = new Bow("bow2", 10);
            archer.AddItem(bow2);
            archer.RemoveItem(bow2);
            Assert.That(archer.Equipment, Has.Exactly(2).Items);
        }
 
        [Test]
        // Ataque base (90) + Bow (40) = 130
        public void TestGetTotalAttack_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(archer.GetTotalAttack(), Is.EqualTo(130));
        }
 
        [Test]
        // Defensa base (30) + Armor (50) = 80
        public void TestGetTotalDefense_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(archer.GetTotalDefense(), Is.EqualTo(80));
        }
    }
}
using System.Security.Cryptography;
using System.IO;
using System;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class DwarvesTest
    {
        private Giant ogro;
        private Dwarves dwarf;
 
        [SetUp]
        public void Setup()
        {
            ogro = new Giant("Ogro Gigante");
            dwarf = new Dwarves("Enano");
        }
 
        [Test]
        // El daño recibido es el ataque del gigante menos la defensa del enano
        public void TestReceiveAttack_ValidAttackDamage_ReducesHealth()
        {
            int initialHealth = dwarf.Health + dwarf.GetTotalDefense();
            dwarf.ReceiveAttack(ogro.GetTotalAttack());
            Assert.That(dwarf.Health, Is.EqualTo(initialHealth - ogro.GetTotalAttack()));
        }
 
        [Test]
        // Un ataque menor o igual a la defensa no reduce la vida
        public void TestReceiveAttack_AttackDamageLowerThanDefense_HealthUnchanged()
        {
            int initialHealth = dwarf.Health;
            dwarf.ReceiveAttack(1);
            Assert.That(dwarf.Health, Is.EqualTo(initialHealth));
        }
 
        [Test]
        // Curar restaura la vida inicial
        public void TestCure_AfterDamage_RestoresInitialHealth()
        {
            int initialHealth = dwarf.Health;
            dwarf.ReceiveAttack(ogro.GetTotalAttack());
            dwarf.Cure();
            Assert.That(dwarf.Health, Is.EqualTo(initialHealth));
        }
 
        [Test]
        // Agregar un item incrementa la lista de equipamiento
        public void TestAddItem_ValidItem_IncreasesEquipmentCount()
        {
            dwarf.AddItem(new Item("Belt", 5, 5));
            Assert.That(dwarf.Equipment, Has.Exactly(4).Items);
        }
 
        [Test]
        // Quitar un item reduce la lista de equipamiento
        public void TestRemoveItem_ExistingItem_DecreasesEquipmentCount()
        {
            Item item = new Item("Belt", 5, 5);
            dwarf.AddItem(item);
            dwarf.RemoveItem(item);
            Assert.That(dwarf.Equipment, Has.Exactly(3).Items);
        }
 
        [Test]
        // Ataque base (70) + Axe (30) = 100
        public void TestGetTotalAttack_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(dwarf.GetTotalAttack(), Is.EqualTo(100));
        }
 
        [Test]
        // Defensa base (50) + Helmet (15) + Shield (20) = 85
        public void TestGetTotalDefense_WithDefaultEquipment_ReturnsExpectedValue()
        {
            Assert.That(dwarf.GetTotalDefense(), Is.EqualTo(85));
        }
    }
}
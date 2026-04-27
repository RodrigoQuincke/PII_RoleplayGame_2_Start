//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main(string[] args)
        {
            Giant ogro = new Giant("Ogro");
            Console.WriteLine("Gigante: " + ogro.Name);

            Wizard mago = new Wizard("Mago de fuego");
            Console.WriteLine("Mago: " + mago.Name);
            Console.WriteLine("Daño de ataque del " + mago.Name + " es " + mago.GetTotalAttack());

            Spell fireball = new Spell("Bola de fuego", 50, 0);
            mago.SpellsBook.AddSpell(fireball);
            Console.WriteLine("Ataque total de " + mago.Name + " es " + mago.GetTotalAttack()); 

            ogro.ReceiveAttack(mago.GetTotalAttack());
            Console.WriteLine("Salud del " + ogro.Name + " luego del ataque es " + ogro.Health);

            mago.ReceiveAttack(ogro.GetTotalAttack());
            Console.WriteLine("Salud del " + mago.Name + " después del ataque es " + mago.Health);

            ogro.Cure();
            Console.WriteLine("Salud del " + ogro.Name + " luego de curarse es " + ogro.Health);

            Elves elfo = new Elves("Elfo del bosque");
            Spell arrow = new Spell("Flecha mágica", 30, 0);
            elfo.SpellsBook.AddSpell(arrow);
            Console.WriteLine("Elfo: " + elfo.Name);
            
            ogro.ReceiveAttack(elfo.GetTotalAttack());
            ogro.ReceiveAttack(mago.GetTotalAttack());
            Console.WriteLine("Salud del " + ogro.Name + " luego de recibir varios ataques es " + ogro.Health);
        }
    }
}

// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins
{
    using System;

    /// <summary>
    /// Class Program regroupant la méthode main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Méthode Main.
        /// </summary>
        /// <param name="args">args.</param>
        static void Main(string[] args)
        {
            ClassesMetier.Dossier d = new ClassesMetier.Dossier("Robert", "Jean", "03/12/1980");
            d.AjoutePrestation(new ClassesMetier.Prestation("P3", DateTime.Now));
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}

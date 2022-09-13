// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins
{
    using System;
    using MesSoins.ClassesMetier;

    /// <summary>
    /// Class Program regroupant la méthode main.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Méthode qui réalise la même situation que le tp.
        /// </summary>
        public static void TestDateDossierPrestation()
        {
            try
            {
                Intervenant intervenant1 = new Intervenant("Dupont", "Jean");
                IntervenantExterne intervenant2 = new IntervenantExterne("Durant", "Annie", "Cardiologue", "Marseille", "0202020202");
                IntervenantExterne intervenant3 = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "030303030");
                Intervenant intervenant4 = new Intervenant("Maurin", "Joelle");
                Intervenant intervenant5 = new Intervenant("Blanchard", "Michel");
                Intervenant intervenant6 = new Intervenant("Tournier", "Helene");

                Prestation prestation1 = new Prestation("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenant1);
                Prestation prestation2 = new Prestation("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenant2);
                Prestation prestation3 = new Prestation("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenant3);
                Prestation prestation4 = new Prestation("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenant4);
                Prestation prestation5 = new Prestation("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenant5);
                Prestation prestation6 = new Prestation("P5", Convert.ToDateTime("10/09/2015 06:00:00"), intervenant6);

                Dossier dossier = new Dossier("Robert", "Jean", new DateTime(1989, 12, 3));
                dossier.AjoutePrestation(prestation1);
                dossier.AjoutePrestation(prestation2);
                dossier.AjoutePrestation(prestation3);
                dossier.AjoutePrestation(prestation4);
                dossier.AjoutePrestation(prestation5);
                dossier.AjoutePrestation(prestation6);
                Console.WriteLine(dossier);
                dossier.GetNbJoursSoinsV1();
                dossier.GetNbPrestationsExternes();
                dossier.GetNbPrestations();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Méthode Main.
        /// </summary>
        /// <param name="args">args.</param>
        private static void Main(string[] args)
        {
            TestDateDossierPrestation();
            Console.ReadKey();
        }
    }
}

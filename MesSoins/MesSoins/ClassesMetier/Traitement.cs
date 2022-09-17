// <copyright file="Traitement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MesSoins.Exceptions;

    /// <summary>
    /// Class Traitement qui contiendra les méthodes de tests.
    /// </summary>
    static class Traitement
    {
        /// <summary>
        /// Méthode qui affichera le dossier exemple.
        /// </summary>
        internal static void TesteDossier()
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
                Console.WriteLine("Nombre de jours soins V3 : " + dossier.GetNbJoursSoinsV2());
            }
            catch (Soins2021Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Permet de faire un test sur le nombre de préstations des intervenants.
        /// </summary>
        /// <returns>Retourne le nombre de préstations de l'intervenant sujet au test.</returns>
        internal static int TesteGetNbPrestations()
        {
            Intervenant intervenant = new Intervenant("Dupont", "Pierre");
            intervenant.AjoutePrestation(new Prestation("P10", Convert.ToDateTime("12/06/2019 06:00:00"), intervenant));
            intervenant.AjoutePrestation(new Prestation("P11", Convert.ToDateTime("15/06/2019 06:00:00"), intervenant));
            return intervenant.GetNbPrestations();
        }

        /// <summary>
        /// Permet de faire un test sur le nombre de préstations des intervenants externes.
        /// </summary>
        /// <returns>Retourne le nombre de préstations de l'intervenant externe sujet au test.</returns>
        internal static int TesteGetNbPrestationsIE()
        {
            IntervenantExterne intervenantexterne = new IntervenantExterne("Terrature", "Julie", "Cardiologue", "Toulon", "0000112233");
            intervenantexterne.AjoutePrestation(new Prestation("P20", Convert.ToDateTime("12/06/2019 06:00:00"), intervenantexterne));
            intervenantexterne.AjoutePrestation(new Prestation("P21", Convert.ToDateTime("14/06/2019 06:00:00"), intervenantexterne));
            intervenantexterne.AjoutePrestation(new Prestation("P22", Convert.ToDateTime("18/07/2019 06:00:00"), intervenantexterne));
            return intervenantexterne.GetNbPrestations();
        }
    }
}

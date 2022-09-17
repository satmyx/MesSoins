// <copyright file="Prestation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using MesSoins.Exceptions;

    /// <summary>
    /// Class Prestation permettant de faire des actions sur la prestation.
    /// </summary>
    class Prestation
    {
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// </summary>
        /// <param name="libelle">Paramètre ayant en valeur le libellé de la prestation.</param>
        /// <param name="dateHeureSoin">Paramètre ayant en valeur la date et heure de soin de la prestation.</param>
        /// <param name="intervenant">Les intervenants liées a la prestation.</param>
        public Prestation(string libelle, DateTime dateHeureSoin, Intervenant intervenant)
        {
            this.libelle = libelle;

            // Check si la date est inférieur a celle actuel.
            if (DateTime.Compare(DateTime.Now.Date, dateHeureSoin.Date) >= 0)
            {
                this.dateHeureSoin = dateHeureSoin;
            }
            else
            {
                throw new Soins2021Exception("La date de création de la préstation ne peut être postèrieur à la date du jour");
            }

            this.intervenant = intervenant;
        }

        /// <summary>
        /// Gets (Property) permet de récupérer le libelle d'une prestation.
        /// </summary>
        public string Libelle { get => this.libelle; }

        /// <summary>
        /// Gets (Property) permet de récupérer la date et heure de soin d'une prestation.
        /// </summary>
        public DateTime DateHeureSoin { get => this.dateHeureSoin; }

        /// <summary>
        /// Gets permet de récupérer la liste des intervenants.
        /// </summary>
        public Intervenant Intervenant { get => this.intervenant; }

        /// <summary>
        /// Méthode CompareTo qui permet de comparer 2 dates entres elles.
        /// </summary>
        /// <param name="prestation1">Première prestation.</param>
        /// <param name="prestation2">Deuxième prestation.</param>
        /// <returns>Retourne un entier si antérieur, identique, ultérieur.</returns>
        public static int CompareTo(Prestation prestation1, Prestation prestation2)
        {
            return DateTime.Compare(prestation1.dateHeureSoin.Date, prestation2.dateHeureSoin.Date);
        }

        /// <summary>
        /// Méthode ToString permettant de renvoyer les informations.
        /// </summary>
        /// <returns>Renvoie les informations de chaque prestation.</returns>
        public override string ToString()
        {
            return "Libelle : " + this.Libelle + "\nDate et Heure : " + this.DateHeureSoin + " - " + this.Intervenant;
        }
    }
}

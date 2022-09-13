// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Spécilalisation de la class Intervenant.
    /// </summary>
    class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private string tel;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntervenantExterne"/> class.
        /// </summary>
        /// <param name="specialite">Paramètre contenant la specialite de l'intervenant.</param>
        /// <param name="adresse">Paramètre contenant l'adresse de l'intervenant.</param>
        /// <param name="tel">Paramètre contenant le numéro de l'intervenant.</param>
        /// <param name="nom">Nom de l'intervenant externe.</param>
        /// <param name="prenom">Prénom de l'intervenant externe.</param>
        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        /// <summary>
        /// Gets la spé de l'intervenant externe.
        /// </summary>
        public string Specialite { get => this.specialite; }

        /// <summary>
        /// Gets or Sets permet de récupérer l'adresse de l'intervenant externe.
        /// </summary>
        public string Adresse { get => this.adresse; set => this.adresse = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer le tel de l'intervenant externe.
        /// </summary>
        public string Tel { get => this.tel; set => this.tel = value; }

        /// <summary>
        /// Méthode To String.
        /// </summary>
        /// <returns>Spécialité, adresse et tél de l'intervenant.</returns>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + " - " + this.Adresse + " - " + this.Tel;
        }
    }
}

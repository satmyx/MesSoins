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
        public IntervenantExterne(string specialite, string adresse, string tel)
            : base("", "")
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }
    }
}

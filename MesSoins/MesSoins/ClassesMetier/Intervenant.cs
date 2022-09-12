// <copyright file="Intervenant.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class (Mère) Intervenant.
    /// </summary>
    class Intervenant
    {
        private string nom;
        private string prenom;

        /// <summary>
        /// Initializes a new instance of the <see cref="Intervenant"/> class.
        /// </summary>
        /// <param name="nom">Paramètre nom contenant le nom d'un intervenant.</param>
        /// <param name="prenom">Paramètre prenom contenant le prenom d'un intervenant.</param>
        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        /// <summary>
        /// Gets permet de récupérer le nom d'un intervenant.
        /// </summary>
        public string Nom { get => this.nom; }

        /// <summary>
        /// Gets permet de récupérer le prénom d'un intervenant.
        /// </summary>
        public string Prenom { get => this.prenom; }
    }
}

// <copyright file="Dossier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  La classe Dossier permet de conserver les données propres à un dossier ouvert pour un patient, et d'y associer les différentes prestations réalisées en précisant pour chacune la
    ///  nature, le jour et heure, ainsi que la personne l'ayant pris en charge.
    /// </summary>
    class Dossier
    {
        private string nom;
        private string prenom;
        private string dateNaissance;
        private List<Prestation> prestation;


        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Contient le nom du patient.</param>
        /// <param name="prenom">Contient le prénom du patient.</param>
        /// <param name="dateNaissance">Contient la date de naissance du patient.</param>
        public Dossier(string nom, string prenom, string dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.prestation = new List<Prestation>();
        }

        /// <summary>
        /// Gets (Property) permet de récupérer le nom d'un patient.
        /// </summary>
        public string Nom { get => this.nom; }

        /// <summary>
        /// Gets (Property) permet de récupérer le prenom d'un patient.
        /// </summary>
        public string Prenom { get => this.prenom; }

        /// <summary>
        /// Gets (Property) permet de récupérer la date de naissance d'un patient.
        /// </summary>
        public string DateNaissance { get => this.dateNaissance; }

        /// <summary>
        /// Gets or Sets permet de récupérer les préstations ainsi que de les modifiers.
        /// </summary>
        public List<Prestation> Prestations { get => this.prestation; set => this.prestation = value; }

        /// <summary>
        /// Méthode qui permet d'ajouter une préstation au Dossier.
        /// </summary>
        /// <param name="prestation">Paramètre pour la prestation.</param>
        public void AjoutePrestation(Prestation prestation)
        {
            this.prestation.Add(prestation);
        }

        /// <summary>
        /// Méthode ToString permettant de print sur la console.
        /// </summary>
        /// <returns>Toutes les valeurs présent dans le dossier.</returns>
        public override string ToString()
        {
            string ListPresta = "";

            foreach (Prestation p in this.Prestations)
            {
                ListPresta += p.Libelle + " " + p.DateHeureSoin;
            }

            return "--- Début du dossier ---" + "\nNom : " + this.Nom + "\nPrénom : " + this.Prenom + "\nDate de naissance : " + this.DateNaissance + "\n--- Prestation ---" + "\n" + ListPresta;
        }

    }
}

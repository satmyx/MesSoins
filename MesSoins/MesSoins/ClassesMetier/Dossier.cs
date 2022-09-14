// <copyright file="Dossier.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    ///  La classe Dossier permet de conserver les données propres à un dossier ouvert pour un patient, et d'y associer les différentes prestations réalisées en précisant pour chacune la
    ///  nature, le jour et heure, ainsi que la personne l'ayant pris en charge.
    /// </summary>
    class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestation> prestation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// </summary>
        /// <param name="nom">Contient le nom du patient.</param>
        /// <param name="prenom">Contient le prénom du patient.</param>
        /// <param name="dateNaissance">Contient la date de naissance du patient.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.prestation = new List<Prestation>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// Constructeur surchargé acceptant une prestation.
        /// </summary>
        /// <param name="nom">Nom du patient.</param>
        /// <param name="prenom">Prénom du patient.</param>
        /// <param name="dateNaissance">Date de naissance du patient.</param>
        /// <param name="prestation">Une prestation.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation prestation)
            : this(nom, prenom, dateNaissance)
        {
            this.AjoutePrestation(prestation);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dossier"/> class.
        /// Constructeur surchargé de dossier acceptant plusieurs prestations.
        /// </summary>
        /// <param name="nom">Nom du patient.</param>
        /// <param name="prenom">Prénom du patient.</param>
        /// <param name="dateNaissance">Date de naissance du patient.</param>
        /// <param name="prestations">Liste des prestations.</param>
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> prestations)
            : this(nom, prenom, dateNaissance)
        {
            foreach (Prestation prestation in prestations)
            {
                this.AjoutePrestation(prestation);
            }
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
        public DateTime DateNaissance { get => this.dateNaissance; }

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
        /// Méthode Nombre de Prestations.
        /// </summary>
        public void GetNbPrestations()
        {
            Console.WriteLine("Nombres de prestations : " + this.Prestations.Count);
        }

        /// <summary>
        /// Méthode pour avoir le nombre de prestations des intervenants externes.
        /// </summary>
        public void GetNbPrestationsExternes()
        {
            int cpt = 0;
            foreach (Prestation p in this.Prestations)
            {
                if (p.Intervenant is IntervenantExterne)
                {
                    cpt++;
                }
            }

            Console.WriteLine("Nombre de soins externes : " + cpt);
        }

        /// <summary>
        /// Méthode pour avoir les jours de soins.
        /// </summary>
        public void GetNbJoursSoinsV1()
        {
            List<DateTime> dates = new List<DateTime>();
            foreach (Prestation presta in this.Prestations)
            {
                if (!dates.Contains(presta.DateHeureSoin.Date))
                {
                    dates.Add(presta.DateHeureSoin.Date);
                }
            }

            Console.WriteLine("Nombre de jours de soins V1 : " + dates.Count);
        }

        /// <summary>
        /// Deuxième méthode qui permet d'avoir les jours de soins.
        /// </summary>
        public void GetNbJoursSoinsV2()
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (Prestation presta in this.Prestations)
            {
                dates.Add(presta.DateHeureSoin.Date);
            }

            Console.WriteLine(dates.Distinct().Count());
        }

        /// <summary>
        /// Méthode ToString permettant de print sur la console.
        /// </summary>
        /// <returns>Toutes les valeurs présent dans le dossier.</returns>
        public override string ToString()
        {
            string listPresta = string.Empty;

            foreach (Prestation p in this.Prestations)
            {
                listPresta += "\n" + p;
            }

            return "--- Début du dossier ---\n" + "\nNom : " + this.Nom + "\nPrénom : " + this.Prenom + "\nDate de naissance : " + this.DateNaissance + "\n\n--- Prestation ---" + "\n" + listPresta;
        }
    }
}

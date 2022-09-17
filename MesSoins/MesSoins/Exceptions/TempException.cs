// <copyright file="TempException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Exception temporaire.
    /// </summary>
    class TempException
    {
        private string application;
        private string classeException;
        private DateTime dateException;
        private string messageException;
        private string userException;
        private string userMachine;

        /// <summary>
        /// Initializes a new instance of the <see cref="TempException"/> class.
        /// Constructeur de la class temporaire des exceptions.
        /// </summary>
        /// <param name="classeException">Classe des exception.</param>
        /// <param name="messageException">Message de l'exception.</param>
        /// <param name="userException">Nom de l'utilisateur.</param>
        /// <param name="userMachine">Machine sur le quel l'erreur est faite.</param>
        public TempException(string classeException, string messageException, string userException, string userMachine)
        {
            this.Application = "Soins2021";
            this.ClasseException = classeException;
            this.DateException = DateTime.Now;
            this.messageException = messageException;
            this.userException = userException;
            this.userMachine = userMachine;
        }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier le nom de l'application.
        /// </summary>
        public string Application { get => this.application; set => this.application = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier la classe des exceptions.
        /// </summary>
        public string ClasseException { get => this.classeException; set => this.classeException = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier la date ou a eu lieu l'exception.
        /// </summary>
        public DateTime DateException { get => this.dateException; set => this.dateException = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier le message relatif a l'exception.
        /// </summary>
        public string MessageException { get => this.messageException; set => this.messageException = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier l'utilisateur ayant fournis l'exception.
        /// </summary>
        public string UserException { get => this.userException; set => this.userException = value; }

        /// <summary>
        /// Gets or Sets permet de récupérer et modifier la machine ayant fournis l'exception.
        /// </summary>
        public string UserMachine { get => this.userMachine; set => this.userMachine = value; }
    }
}

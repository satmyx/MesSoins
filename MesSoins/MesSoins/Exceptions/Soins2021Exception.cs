// <copyright file="Soins2021Exception.cs" company="PlaceholderCompany">
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
    /// Class comportant les Exceptions du programme.
    /// </summary>
    class Soins2021Exception : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Soins2021Exception"/> class.
        /// Constructeur des Exceptions.
        /// </summary>
        /// <param name="message">Message que renvoie l'exception.</param>
        public Soins2021Exception(string message)
            : base(message)
        {
        }
    }
}

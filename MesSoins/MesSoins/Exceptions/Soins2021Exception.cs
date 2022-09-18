// <copyright file="Soins2021Exception.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MesSoins.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// Class comportant les Exceptions du programme.
    /// </summary>
    class Soins2021Exception : Exception
    {
        private static List<Dictionary<string, string>> listLog = new List<Dictionary<string, string>>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Soins2021Exception"/> class.
        /// Constructeur des Exceptions.
        /// </summary>
        /// <param name="message">Message que renvoie l'exception.</param>
        public Soins2021Exception(string message)
            : base(message)
        {
            // Source utiliser : https://www.youtube.com/watch?v=hy-A6ppJ45U&ab_channel=FastPath.
            Dictionary<string, string> log = new Dictionary<string, string>
            {
                { "Application", "Soins2021" },
                { "ClasseException", this.GetType().Name.ToString() },
                { "DateException", DateTime.Now.ToString() },
                { "MessageException", this.Message },
                { "UserException", Environment.UserName },
                { "UserMachine", Environment.MachineName },
            };
            listLog.Add(log);
            string logJson = JsonConvert.SerializeObject(Soins2021Exception.listLog, Formatting.Indented);
            string filePath = @"D:\MesSoins\MesSoins\MesSoins\ExceptionData.json";
            File.WriteAllText(filePath, logJson);
        }
    }
}

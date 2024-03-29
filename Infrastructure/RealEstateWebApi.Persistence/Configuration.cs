﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {

                ConfigurationManager configurationManager = new ConfigurationManager();
                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/RealEstateWebApi.WebApi"));
                    configurationManager.AddJsonFile("appsettings.json");
                }
                catch (Exception)
                {
                    configurationManager.AddJsonFile("appsettings.json");
                }

                return configurationManager.GetConnectionString("PostgreSQL");


            }
            //get
            //{
            //    return String.Empty;
            //}
        }
    }
}

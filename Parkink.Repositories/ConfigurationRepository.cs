using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Models;

namespace Parking.Repositories
{
    public class ConfigurationRepository
    {

        public ConfigurationDTO GetConfiguration()
        { 
            using (var context = new PLTOEntities())
            {
                var result = context.Configurations.ToList();
                var config = new ConfigurationDTO();

                foreach (var item in result)
                {
                    switch(item.ConfigurationName)
                    {
                        case "Name":
                            config.Name = item.ConfigurationValue;
                            break;
                        case "Nit":
                            config.Nit = item.ConfigurationValue;
                            break;
                        case "Address":
                            config.Address = item.ConfigurationValue;
                            break;
                        case "Telephone":
                            config.Telephone = item.ConfigurationValue;
                            break;
                        case "Schedule":
                            config.Schedule = item.ConfigurationValue;
                            break;
                        case "Regime":
                            config.Regime = item.ConfigurationValue;
                            break;
                        case "FootPage":
                            config.FootPage = item.ConfigurationValue;
                            break;
                    }                   
                }
                return config;
            }
        }
    }
}

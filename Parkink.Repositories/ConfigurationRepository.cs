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
                        case "FootTitle":
                            config.FootTitle = item.ConfigurationValue;
                            break;
                        case "DayHours":
                            config.DayHours = item.ConfigurationValue;
                            break;
                        case "StartNight":
                            config.StartNight = item.ConfigurationValue;
                            break;
                        case "FootItems":
                            config.FootItems = item.ConfigurationValue;
                            break;
                    }                   
                }
                return config;
            }
        }

        public string GetReceiptNumber()
        {

            using (var context = new PLTOEntities())
            {
                var data = context.Configurations.FirstOrDefault(x => x.ConfigurationName == "ReceiptNumber");

                var result = int.Parse(data.ConfigurationValue) + 1;

                data.ConfigurationValue = result.ToString();

                context.SaveChanges();

                return result.ToString();
            }
        }
    }
}

using Parking.Models;
using System.Collections.Generic;
using System.Linq;

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
                        case "StartDay":
                            config.StartDay = item.ConfigurationValue;
                            break;
                        case "Lockers":
                            config.Lockers = int.Parse(item.ConfigurationValue);
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

        public List<Configuration> GetConfigData()
        {
            using (var context = new PLTOEntities())
            {
                return context.Configurations.ToList();
            }
        }


        public Configuration GetConfigDataByID(int configurationID)
        {
            using (var context = new PLTOEntities())
            {
                return context.Configurations.FirstOrDefault(x => x.ConfigurationID == configurationID);
            }
        }

        public Configuration SaveConfiguration(Configuration config)
        {
            using (var context = new PLTOEntities())
            {
                var result = context.Configurations.FirstOrDefault(x => x.ConfigurationID == config.ConfigurationID);

                if (result == null)
                {
                    result = new Configuration()
                    {
                        ConfigurationName = config.ConfigurationName,
                        ConfigurationValue = config.ConfigurationValue
                    };

                    context.Configurations.Add(result);
                }
                else
                {
                    result.ConfigurationName = config.ConfigurationName;
                    result.ConfigurationValue = config.ConfigurationValue;
                }

                context.SaveChanges();

                config.ConfigurationID = result.ConfigurationID;

                return config;
            }
        }
    }
}

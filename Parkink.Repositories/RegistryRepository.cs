using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositories
{
    public class RegistryRepository
    {
        public Registry RegisterVehicle(Registry registry)
        {
            using (var context = new PLTOEntities())
            {
                var reg = context.Registries.FirstOrDefault(r => r.Plate == registry.Plate && r.ExitDate == null);

                if (reg == null)
                {
                    reg = new Registry
                    {
                        Plate = registry.Plate,
                        EntryDate = registry.EntryDate,
                    };
                    context.Registries.Add(reg);                  
                }
                else
                {
                    //var u = context.Users.FirstOrDefault(cl => cl.Document == userToSave.Document);

                    //u.Name = userToSave.Name;
                    //u.Birthday = userToSave.Birthday;
                    //u.Email = userToSave.Email;
                    //u.Celphone = userToSave.Celphone;
                    //u.Phone = userToSave.Phone;
                    //u.Profesion = userToSave.Profesion;
                    //u.Activity = userToSave.Activity;
                    //u.PollingPlace = userToSave.PollingPlace;
                    //u.Neighborhood = userToSave.Neighborhood;
                    //flag = 2;
                }

                context.SaveChanges();

                registry.RegistryID = reg.RegistryID;
            }

            return registry;
        }
    }
}

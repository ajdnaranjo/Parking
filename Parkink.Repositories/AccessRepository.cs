using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Repositories
{
    public class AccessRepository
    {

        public bool ValidUser(string user, string pass)
        {
            using (var context = new PLTOEntities())
            {
                var result = context.AppUsers.FirstOrDefault(x => x.AppUserID == user && x.Password == pass);

                if (result != null) return true;
                else return false;
            }
        }

        public List<Forms> ValidFormsPerRol(int rolID)
        {
            using (var context = new PLTOEntities())
            {
                var data = (from r in context.Rols
                            join rf in context.RolForms on r.RolID equals rf.RolID
                            join f in context.Forms on rf.FormID equals f.FormID
                            where r.RolID == rolID
                            select f).ToList();

                return data;
            }
        }
    }
}

using Parking.Models;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

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
                            join f in context.Forms1 on rf.FormID equals f.FormID
                            where r.RolID == rolID
                            select f).ToList();

                return data;
            }
        }

        public List<RolAccessDTO> GetRolFormAccess(string appUserID)
        {
            using (var context = new PLTOEntities())
            {
                var data = (from au in context.AppUsers
                            join r in context.Rols on au.RolID equals r.RolID
                            join rf in context.RolForms on r.RolID equals rf.RolID
                            join f in context.Forms1 on rf.FormID equals f.FormID
                            where au.AppUserID == appUserID
                            select new RolAccessDTO
                            {
                                AppUserID = au.AppUserID,
                                RolID = r.RolID,
                                RolName = r.RolName,
                                FormID = f.FormID,
                                FormName = f.FormName
                            }
                            ).ToList();

                return data;
            }
        }
    }
}

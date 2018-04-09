using Parking.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Parking.Repositories
{
    public class SecurityRepository
    {

        public bool ValidUser(string user, string pass)
        {            
            using (var context = new PLTOEntities())
            {
                var result = context.AppUsers.FirstOrDefault(x => x.AppUserID == user && x.Status == true);

                if (result != null)
                {
                    if (Decrypt(result.Password) == pass) return true;
                    else return false;
                }
                else return false;
            }
        }

        public int GetUserID(string appUserID)
        {
            using (var context = new PLTOEntities())
            {
                return context.AppUsers.FirstOrDefault(x => x.AppUserID == appUserID && x.Status == true).UserID;
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

        public List<RolAccessDTO> GetRolFormAccess(int appUserID)
        {
            using (var context = new PLTOEntities())
            {
                var data = (from au in context.AppUsers
                            join r in context.Rols on au.RolID equals r.RolID
                            join rf in context.RolForms on r.RolID equals rf.RolID
                            join f in context.Forms1 on rf.FormID equals f.FormID
                            where au.UserID == appUserID
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
        
        public string Encrypt( string _stringToEncrypt)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_stringToEncrypt);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        
        public string Decrypt(string _stringToDecrypt)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_stringToDecrypt);            
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public AppUser GetAppUserByID(int appUserID)
        {
            using (var context = new PLTOEntities())
            {
                return context.AppUsers.FirstOrDefault(x => x.UserID == appUserID );
            }
        }

    }
}

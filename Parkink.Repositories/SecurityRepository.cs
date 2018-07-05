using Parking.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Parking.Models;

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

        public bool UpdatePass( int userID, string Pass)
        {
            var flag = false;
            using (var context = new PLTOEntities())
            {
                var user = context.AppUsers.FirstOrDefault(x => x.UserID == userID  && x.Status == true);

                if (user != null)
                {
                    user.Password = Encrypt(Pass);

                    context.SaveChanges();

                    flag = true;
                }

                return flag;
            }
        }

        public AppUser GetAppUser(string appUserID)
        {
            using (var context = new PLTOEntities())
            {
                return context.AppUsers.FirstOrDefault(x => x.AppUserID == appUserID);
            }
        }

        public bool EditUser(AppUser appUser)
        {
            var flag = false;
            using (var context = new PLTOEntities())
            {
                var user = context.AppUsers.FirstOrDefault(x => x.AppUserID == appUser.AppUserID);

                if (user == null)
                {

                    user = new AppUser
                    {
                        AppUserID = appUser.AppUserID,
                        Name = appUser.Name,
                        Password = Encrypt(appUser.Password),
                        Status = appUser.Status,
                        RolID = appUser.RolID
                    };
                    context.AppUsers.Add(user);

                    flag = true;

                } else
                {
                    user.Name = appUser.Name;
                    user.Password = Encrypt(appUser.Password);
                    user.Status = appUser.Status;
                    user.RolID = appUser.RolID;

                    flag = true;
                }

                context.SaveChanges();

                return flag;
            }
        }

        public List<Rol> GetRols()
        {
            using (var context = new PLTOEntities())
            {
                return context.Rols.Where(x => x.Status == true).ToList();
            }
        }

        public List<RolAccessDTO> GetRolsById(int rolId)
        {
            using (var context = new PLTOEntities())
            {
                var result = context.usp_SelectRolAccessData(rolId);
                var data = new List<RolAccessDTO>();

                foreach (var item in result)
                {
                    var dto = new RolAccessDTO()
                    {
                           FormID = item.FormID,
                           FormName = item.FormName,
                           Description = item.Description,
                           Status = (bool)item.Status
                    };

                    data.Add(dto);
                }

                return data;
            }
        }

        public List<RolForm> EditRolForm(List<RolForm> rolForm, int rolId)
        {
            using (var context = new PLTOEntities())
            {
                var rols = context.RolForms.Where(x => x.RolID == rolId).ToList();

                foreach (var rol in rols)
                {
                    context.RolForms.Remove(rol);                    
                }
                context.SaveChanges();

                foreach (var rol in rolForm)
                {
                    context.RolForms.Add(rol);
                }

                context.SaveChanges();

                return context.RolForms.Where(x => x.RolID == rolId).ToList();
            }
        }

        public Rol EditRol(Rol rol)
        {
            using (var context = new PLTOEntities())
            {
                var r = context.Rols.FirstOrDefault(x => x.RolName == rol.RolName);

                if (r == null)
                {
                    r = new Rol
                    {
                      RolName = rol.RolName,
                      Status = rol.Status
                    };
                    context.Rols.Add(r);                    
                }
                else
                {
                    r.RolName = rol.RolName;
                    r.Status = rol.Status;
                }

                context.SaveChanges();

                return context.Rols.FirstOrDefault(x => x.RolName == rol.RolName);
            }
        }
    }
}

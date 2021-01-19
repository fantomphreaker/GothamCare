using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.AdminData
{
    public class SqlAdminData : IAdminData
    {
        private GothamCareApiContext _gothamCareApiContext;
        public SqlAdminData(GothamCareApiContext gothamCareApiContext)
        {
            _gothamCareApiContext = gothamCareApiContext;
        }
        public Admin AddAdmin(Admin admin)
        {
            _gothamCareApiContext.Admins.Add(admin);
            _gothamCareApiContext.SaveChanges();
            return admin;
        }

        public void DeleteAdmin(Admin admin)
        {
            _gothamCareApiContext.Admins.Remove(admin);
            _gothamCareApiContext.SaveChanges();
        }

        public Admin GetAdmin(string emailId)
        {
            Admin admin = _gothamCareApiContext.Admins.Find(emailId);
            return admin;
        }

        public Admin ModifyAdminDetails(Admin admin)
        {
            Admin _admin = _gothamCareApiContext.Admins.Find(admin.EmailId);
            _gothamCareApiContext.Admins.Remove(_admin);
            _gothamCareApiContext.Admins.Add(admin);
            _gothamCareApiContext.SaveChanges();
            return admin;
        }
    }
}

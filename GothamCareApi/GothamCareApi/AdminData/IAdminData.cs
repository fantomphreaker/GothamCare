using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.AdminData
{
    public interface IAdminData
    {
        public Admin AddAdmin(Admin admin);
        public Admin GetAdmin(string emailId);
        public Admin ModifyAdminDetails(Admin admin);
        public void DeleteAdmin(Admin admin);
        
    }
}

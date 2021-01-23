using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.AdminService
{
    public interface IAdminService
    {
        Admin Login(string email, string password);
    }
}

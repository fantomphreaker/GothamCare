using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.AdminService
{
    public class AdminService : IAdminService
    {
        private GothamCaresApiContext _gothamCaresApiContext;

        public AdminService(GothamCaresApiContext gothamCaresApiContext)
        {
            _gothamCaresApiContext = gothamCaresApiContext;
        }
        public Admin Login(string email, string password)
        {
            return _gothamCaresApiContext.Admins.Find(email);
        }
    }
}

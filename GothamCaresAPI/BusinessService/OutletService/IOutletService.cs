using DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.OutletService
{
    public interface IOutletService
    {
        List<Outlet> GetOutlets();

        Outlet GetOutlet(int Id);

        Outlet AddOutlet(Outlet outlet);

        Outlet ModifyOutlet(Outlet outlet);

        void DeleteOutlet(Outlet outlet);
    }
}

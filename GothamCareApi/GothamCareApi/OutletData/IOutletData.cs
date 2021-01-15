using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.OutletData
{
    public interface IOutletData
    {
        List<Outlet> GetOutlets();

        Outlet GetOutlet(int Id);

        Outlet AddOutlet(Outlet outlet);

        Outlet ModifyOutlet(Outlet outlet);

        void DeleteOutlet(Outlet outlet);


    }
}

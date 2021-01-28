using DataService;
using DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.OutletService
{
    public class OutletService : IOutletService
    {
        private GothamCaresApiContext _gothamCaresApiContext;
        public OutletService(GothamCaresApiContext gothamCaresApiContext)
        {
            _gothamCaresApiContext = gothamCaresApiContext;
        }

        public Outlet AddOutlet(Outlet outlet)
        {
            List<Outlet> outlets = GetOutlets();
            bool isOutletRedundant = false;
            foreach (Outlet x in outlets)
            {
                if ((x.OutletName == outlet.OutletName) && (x.Date == outlet.Date))
                {
                    isOutletRedundant = true;
                }
            }

            if (!isOutletRedundant)
            {
                _gothamCaresApiContext.Outlets.Add(outlet);
                _gothamCaresApiContext.SaveChanges();
                return outlet;
            }

            return null;
        }

        public void DeleteOutlet(Outlet outlet)
        {
            _gothamCaresApiContext.Outlets.Remove(outlet);
            _gothamCaresApiContext.SaveChanges();

        }

        public Outlet GetOutlet(int Id)
        {
            var outlet = _gothamCaresApiContext.Outlets.Find(Id);
            return outlet;
        }

        public List<Outlet> GetOutlets()
        {
            return _gothamCaresApiContext.Outlets.OrderBy(x => x.FoodType).ThenBy(x => x.Date).ThenBy(x => x.StreetName).ToList();
        }

        public Outlet ModifyOutlet(Outlet outlet)
        {
            var id = outlet.Id;
            var oldOutlet = _gothamCaresApiContext.Outlets.Find(id);
            _gothamCaresApiContext.Outlets.Remove(oldOutlet);
            _gothamCaresApiContext.Outlets.Add(outlet);
            _gothamCaresApiContext.SaveChanges();

            return outlet;

        }
    }
}

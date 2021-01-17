using GothamCareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GothamCareApi.OutletData
{
    public class SqlOutletData : IOutletData
    {
        private GothamCareApiContext _gothamCareApiContext;
        public SqlOutletData(GothamCareApiContext gothamCareApiContext)
        {
            _gothamCareApiContext = gothamCareApiContext;
        }
        public Outlet AddOutlet(Outlet outlet)
        {
            _gothamCareApiContext.Outlets.Add(outlet);
            _gothamCareApiContext.SaveChanges();

            return outlet;
        }

        public void DeleteOutlet(Outlet outlet)
        {
            throw new NotImplementedException();
        }

        public Outlet GetOutlet(int Id)
        {
            var outlet = _gothamCareApiContext.Outlets.Find(Id);
            return outlet;
        }

        public List<Outlet> GetOutlets()
        {
            return _gothamCareApiContext.Outlets.ToList();
        }

        public Outlet ModifyOutlet(Outlet outlet)
        {
            var id = outlet.Id;
            var oldOutlet = _gothamCareApiContext.Outlets.Find(id);
            _gothamCareApiContext.Outlets.Remove(oldOutlet);
            _gothamCareApiContext.Outlets.Add(outlet);
            _gothamCareApiContext.SaveChanges();

            return outlet;

        }
    }
}

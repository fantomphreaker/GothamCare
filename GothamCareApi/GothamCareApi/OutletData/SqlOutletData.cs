﻿using GothamCareApi.Models;
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
            throw new NotImplementedException();
        }

        public void DeleteOutlet(Outlet outlet)
        {
            throw new NotImplementedException();
        }

        public Outlet GetOutlet(int Id)
        {
            return _gothamCareApiContext.Outlets.SingleOrDefault(x => x.Id == Id);
        }

        public List<Outlet> GetOutlets()
        {
            return _gothamCareApiContext.Outlets.ToList();
        }

        public Outlet ModifyOutlet(Outlet outlet)
        {
            throw new NotImplementedException();
        }
    }
}

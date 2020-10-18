using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TaxiDoor.Data;
using TaxiDoor.Persistance;

namespace TaxiDoor.Service
{
    public class VendorService
    {

        public List<Vendor> GetAllVendors()
        {

            TaxiContext context = new TaxiContext();
            return context.Vendors.ToList();


            return null;

        }


        public Vendor GetById(int id)
        {
            TaxiContext context = new TaxiContext();
            return context.Vendors.FirstOrDefault(x => x.Id == id);
        }





        public Vendor GetByEmail(int id) 
        {
            TaxiContext context = new TaxiContext();
            return context.Vendors.FirstOrDefault(x => x.Id == id);
        }

    }
}

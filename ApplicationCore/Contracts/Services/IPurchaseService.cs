using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IPurchaseService
    {
        int AddPurchase(Purchase purchase);
        int UpdatePurchase(Purchase purchase, int id);
        int DeletePurchase(int id);
        IEnumerable<Purchase> GetAllPurchase();
        Purchase GetPurchaseById(int id);
    }
}

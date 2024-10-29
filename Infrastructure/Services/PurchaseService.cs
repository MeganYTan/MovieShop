using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PurchaseService : IPurchaseService
    {
        private IPurchaseRepository _repository;
        public PurchaseService(IPurchaseRepository repo)
        {
            _repository = repo;
        }

        public int AddPurchase(Purchase purchase)
        {
            return _repository.Insert(purchase);
        }

        public int DeletePurchase(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Purchase> GetAllPurchase()
        {
            return _repository.GetAll();
        }

        public Purchase GetPurchaseById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdatePurchase(Purchase purchase, int id)
        {
            // TO DO
            return 0;
        }
    }
}

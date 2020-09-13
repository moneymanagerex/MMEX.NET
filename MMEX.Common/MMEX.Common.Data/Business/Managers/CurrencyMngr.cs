using MMEX.Common.Data.DataAccess;
using MMEX.Common.Data.Models;
using System.Collections.Generic;

namespace MMEX.Common.Data.Business.Managers
{
    public class CurrencyMngr
    {
        private readonly CurrencyRepository _repository;

        public CurrencyMngr(string DbPath)
        {
            _repository = new CurrencyRepository(DbPath);
        }

        public Currency GetById(int id)
        {
            return _repository.GetByKey(id);
        }

        public IList<Currency> GetAll()
        {
            return new List<Currency>(_repository.GetAll());
        }

        public int Save(Currency currency)
        {
            return _repository.Save(currency);
        }

        public int Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}

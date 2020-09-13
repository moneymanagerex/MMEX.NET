using MMEX.Common.Data.Models;
using System.Collections.Generic;

namespace MMEX.Common.Data.DataAccess
{
    public class AccountRepository
    {
        SQLiteDatabase _db = null;

        public AccountRepository(string DbPath)
        {
            _db = new SQLiteDatabase(DbPath);
        }

        public Account GetById(int id)
        {
            return _db.GetItem<Account>(id);
        }

        public IEnumerable<Account> GetAll()
        {
            return _db.GetItems<Account>();
        }

        public int Save(Account account)
        {
            return _db.SaveItem<Account>(account);
        }

        public int Delete(int id)
        {
            return _db.DeleteItem<Account>(id);
        }
    }
}

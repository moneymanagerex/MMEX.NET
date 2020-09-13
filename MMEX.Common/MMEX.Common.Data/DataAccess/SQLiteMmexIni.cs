using MMEX.Common.Data.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MMEX.Common.Data.DataAccess
{
    public class SQLiteMmexIni
    {
        static object locker = new object();

        SQLiteConnection database;

        public SQLiteMmexIni(string DbPath)
        {
            // database = DependencyService.Get<ISQLite>().GetConnection();
            database = new SQLiteConnection(DbPath);
            database.CreateTable<OptionLocal>();;
        }

        static readonly object Locker = new object();

        public IEnumerable<T> GetItems<T>() where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                return (from i in database.Table<T>() select i).ToList();
            }
        }

        public T GetItem<T> (int id) where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                return database.Table<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public int SaveItem<T> (T item) where T : Business.Contracts.IEntity
        {
            lock (Locker)
            {
                try
                {
                    if (item.Id != 0)
                    {
                        database.Update(item);
                        Debug.WriteLine("INI DATABASE UPDATE -> " + item.ToString() + " - " + item.Id);
                        return item.Id;
                    }
                    Debug.WriteLine("INI DATABASE INSERT -> " + item.ToString() + " - " + item.Id);
                    return database.Insert(item);
                }
                catch (Exception /*e*/)
                {
                    return 0;
                }
            }
        }

        public int DeleteItem<T> (int id) where T : Business.Contracts.IEntity, new()
        {
            lock (Locker)
            {
                Debug.WriteLine("INI DATABASE DELETE -> " + id.ToString());
                return database.Delete<T>(id);
            }
        }
    }
}

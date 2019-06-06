using GIMS.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using GIMS.Db;



namespace GIMS.DataLayer.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public Supplier Add(Supplier entity)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DBConnectionHelper.SQLConnectionString))
                {
                    var sql = "INSERT INTO Suppliers OUTPUT Inserted.Id VALUES(@supplierId, @name, @contactNumber, @address, @isActive, @remarks)";

                    entity.Id = db.Execute(sql, entity);

                    return entity;
                }
            }
            catch(Exception ex)
            {
                //Logger.Fatal
                throw new ApplicationException($"DB exception : {ex.Message}");
            }
        }

        public void AddMany(IEnumerable<Supplier> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(Guid id)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DBConnectionHelper.SQLConnectionString))
                {
                    var sql = "SELECT * FROM Suppliers WHERE SupplierId = @supplierId";

                    return db.Query<Supplier>(sql, new { supplierId = id }).FirstOrDefault(); ;
                }
            }
            catch (Exception ex)
            {
                //Logger.Fatal
                throw new ApplicationException($"DB exception : {ex.Message}");
            }

        }

        public Supplier Get(string supplierName)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(DBConnectionHelper.SQLConnectionString))
                {
                    var sql = "SELECT * FROM Suppliers WHERE SupplierName like '%@supplierName%'";

                    return db.Query<Supplier>(sql, new { supplierName }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                //Logger.Fatal
                throw new ApplicationException($"DB exception : {ex.Message}");
            }
        }

        public IEnumerable<Supplier> GetAll()
        {
            //TODO I need pagination here
            try
            {
                using (IDbConnection db = new SqlConnection(DBConnectionHelper.SQLConnectionString))
                {
                    var sql = "SELECT * FROM Suppliers";

                    return db.Query<Supplier>(sql).AsEnumerable();
                }
            }
            catch (Exception ex)
            {
                //Logger.Fatal
                throw new ApplicationException($"DB exception : {ex.Message}");
            }
        }

        public IEnumerable<Supplier> GetMany(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetMany(Guid id)
        {
            throw new NotImplementedException();
        }

        public Supplier Update(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}

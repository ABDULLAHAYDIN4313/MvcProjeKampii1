using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<TableClass> : IRepository<TableClass> where TableClass : class //tableclass writers gelirse
    {
        Context context = new Context();
        DbSet<TableClass> _object;
        public GenericRepository()//ctor constracter metot yapıcı metot . çünkü hangi tabloda çalışacağımız belli değil
        {
            _object = context.Set<TableClass>();
            //objemiz context sınıfından class a gönderilen değperle oluşturulacak _object te =context.Writers atanır
        }

        public void Delete(TableClass Item)
        {
            _object.Remove(Item); //context.Writers.Remove(Item); gibi çalışacak
            context.SaveChanges();
        }

        public void Insert(TableClass Item)
        {
            _object.Add(Item);
            context.SaveChanges();
        }

        public List<TableClass> List()
        {
            return _object.ToList();
        }

        public List<TableClass> List(Expression<Func<TableClass, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(TableClass Item)
        {
            context.SaveChanges();
        }
    }
}

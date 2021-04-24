using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 

namespace DataAccessLayer.Abstract
{
    interface IRepository<TableClass>
    {
        //crud operasyonlarınn tanımlanması
        //type name()
        List<TableClass> List();
        List<TableClass> List(Expression<Func<TableClass, bool>> filter);
        void Insert(TableClass Item);
        void Update(TableClass Item);
        void Delete(TableClass Item);

    }
}

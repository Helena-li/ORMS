using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMS.DAL
{
    interface IServices<T>
    {
        int addItem(T item);
        void updateItem(T item);
        T getItem(int id);
        T getItem(string str);
        void deleteItem(int id);
        //T getNextItem(T item);
    }
}

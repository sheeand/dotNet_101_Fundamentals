using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    // Interface with generics
    interface ICrudRepository<T, TT>
    {
        bool Create(T model);
        bool Read();
        bool Update();
        bool Delete();
        TT GetAll();

    }
}

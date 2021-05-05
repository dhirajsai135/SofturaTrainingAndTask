using System;
using System.Collections.Generic;
using System.Text;

namespace TransportManagementBLLibrary
{
   public interface ILogin<T>
    {
        bool login(T t);
        void Add(T t);

    }
}

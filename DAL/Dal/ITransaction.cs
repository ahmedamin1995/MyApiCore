using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dal
{
    interface ITransaction:IDisposable
    {
        void Commit();
        void RollBack();
    }
}

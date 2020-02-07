using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dal
{
    public class DbTransaction : ITransaction
    {
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    class GarageGeneric<T> : IEnumerable<T>

    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

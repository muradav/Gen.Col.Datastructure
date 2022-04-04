using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure.Task
{
    internal class Exceptions
    {
        public void CapacityLimitException(int capacity, int count)
        {
            if (count == capacity)
            {
                throw new Exception("Out of range of capacity");

            }

        }

        public void NotFoundException(int? id)
        {
            if (id == null)
            {
                throw new Exception("Product not found");
            }
        }

        public void ProductCountIsZeroException(int count)
        {
            if (count == 0)
            {
                throw new Exception("Product out of stock");
            }
        }
    }
}

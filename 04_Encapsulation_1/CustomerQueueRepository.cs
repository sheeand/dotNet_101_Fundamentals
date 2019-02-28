using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapsulation_1
{
    public class CustomerQueueRepository
    {
        private Queue<Customer> _customerQueue;

        // constructor
        public CustomerQueueRepository()
        {
            _customerQueue = new Queue<Customer>();
        }

        public void AddNewCallerToQueue(Customer cust)
        {
            _customerQueue.Enqueue(cust);
        }

        public Customer LookAtNextCallerInQueue()
        {
            if (_customerQueue.Count == 0)
            {
                return null;
            }
            else
                {
                    return _customerQueue.Peek();
                }
            }

        public void RemoveNextCallerFromQueue()
        {
            _customerQueue.Dequeue();
        }


    }
}

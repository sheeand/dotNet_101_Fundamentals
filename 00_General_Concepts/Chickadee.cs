using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    class Chickadee : IBird, ICrudRepository<string, Bird>
    {
        public bool Create(Bird model)
        {
            throw new NotImplementedException();
        }

        public bool Create(string model)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void FlapWings()
        {
            throw new NotImplementedException();
        }

        public Bird GetAll()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            Console.WriteLine("Chika dee dee dee dee");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public bool Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}

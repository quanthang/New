using WAD.Models;

namespace System.Data
{
    public class Entity
    {
        public class DbSet<T>
        {
            internal object ToList()
            {
                throw new NotImplementedException();
            }

            internal Exam Find(int? id)
            {
                throw new NotImplementedException();
            }

            internal void Add(Exam exam)
            {
                throw new NotImplementedException();
            }

            internal void Remove(Exam exam)
            {
                throw new NotImplementedException();
            }
        }
    }
}
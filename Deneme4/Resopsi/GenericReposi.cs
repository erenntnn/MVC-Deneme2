using Deneme4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme4.Resopsi
{
    public class GenericReposi<T> where T :class, new()
    {
        
            Context c = new Context();

            public void Tadd(T p)
            {
                c.Set<T>().Add(p);
                c.SaveChanges();
            }

            public void TRemove(T p)
            {
                c.Set<T>().Remove(p);
                c.SaveChanges();
            }

            public void TUpdate(T p)
            {
                c.Set<T>().Update(p);
                c.SaveChanges();
            }

            public List<T>TList()
            {
                return c.Set<T>().ToList();
            }
        public void TGet(int id)
        {
            c.Set<T>().Find(id);
        }
        }
    }


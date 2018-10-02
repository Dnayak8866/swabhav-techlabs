using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwabhavQAdapter
{
    class GenericAdapter<T>:IEnumerable<T>
    {
        private LinkedList<T> nameQueues;
        public GenericAdapter()
        {
            this.nameQueues = new LinkedList<T>();

        }
        public void eQueue(T name)
        {
            nameQueues.AddLast(name);
        }
        public void  deQueue()
        {
             nameQueues.RemoveFirst();
        }
        public int getCount()
        {
            return nameQueues.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)nameQueues).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)nameQueues).GetEnumerator();
        }
    }
}

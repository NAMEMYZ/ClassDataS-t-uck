
using System;

namespace Collection
{
    public class ArrayCollection : Collection
    {
        private int cap, SIZE;
        private object[] data;  
        
        public  ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        private void ensureCapasity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] tempdata = new object[2 * SIZE];
                for (int i = 0; i < SIZE; i++)
                {
                    tempdata[i] = data[i];
                }
                data = tempdata;
            }
        }
        public void Add(object e)
        {
            if (e == null)
                throw new System.ArgumentNullException();
            ensureCapasity();
            data[SIZE++] = e;

        }

        public bool Contains(object e)
        {
            return IndexOf(e) != -1;
        }

        private int IndexOf(object e)
        {
            for (int i = 0;i < SIZE; i++)
                if (data[i].Equals(e))
                    return i;
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            int i = IndexOf(e);
            if (i != -1)
            {
                data[i] = data[--SIZE];
                data[SIZE] = null;
            }
        }

        public int size()
        {
            return SIZE;
        }
    }
}

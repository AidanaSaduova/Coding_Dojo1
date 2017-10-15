using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo1.Stack
{
    class Stack<T>
    {
        private NextVal<T> current;
        public void push(T elem)
        {
            if (current == null)
            {
                current = new NextVal<T>() { value = elem, next = null};
            }
            else
            {
                NextVal<T> temp = new NextVal<T>() { value = elem,  next = current };
                current = temp;
            }
        }

        public T pop()
        {
            if (current != null)
            {
                
                current = current.next;
                T tmp = current.value;
                return tmp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        

        public T peek()
        {
            if (current!=null)
            {
                return current.value;
            }
            else
            {
                return default(T);
            }
 
        }




    }
}

using System.Collections.Generic;
using System.ComponentModel;

namespace Generics
{
    public class MagicHat<T> where T: class, IAmMagical, new()
    {
        public void Fill()
        {
            for (int i = 0; i < 5; i++)
            {
                T newThing = new T();        // 2 - Can't create instance without new() constraint; snip: new() ;  must be last. 
                _queue.Enqueue(newThing);
            }
        }

        public void Disappear()
        {
            while (_queue.Count > 0)
            {
                T thing = _queue.Dequeue();
                thing.Disappear();          // 3 -  Add interface constraint
            }
        }

        public void Put(T newThing)
        {
            //if (newThing != null)           // 4 - OK to compare T to a null reference;  an option here would be to use the 'default' keyword.   
            if (newThing != default(T))       // alternate syntax;  reference types have a default value of null.   (numeric values have 0)
            {
                _queue.Enqueue(newThing);
            }
         }

        public T Pull()
        {
            if (_queue.Count == 0)         
            {
                return null;                // 1 - can't assign null with with assigning T as a reference type(class) in class declaration;   snip:  where T: class
            }

            return _queue.Dequeue();
        }

        readonly Queue<T> _queue = new Queue<T>();
    }
}

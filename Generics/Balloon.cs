using System;

namespace Generics
{
    public class Balloon : IAmMagical
    {
        public string Color { get; set; }        
        
        public void Inflate()
        {
            // ...  illustrative purposes; implementation details are out of scope
        }
        public void Pop()
        {
            // ...  illustrative purposes; implementation details are out of scope
        }

        public void AppearOutOfThinAir()
        {
            // // ... TODO: Add implementation code
            throw new NotImplementedException();
        }

        public void Disappear()
        {
            // ... TODO: Add implementation code
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class MyInputP : IOOPInputP
    {
        private IMyTracer _myTracer;
        public MyInputP(IMyTracer? tracer = null)
        {
            _myTracer = tracer;
        }
      public List <Animal> Processor()
        {
            this._myTracer.Trace("Started processing animals!");
            List<Animal> test = new List<Animal>();
            test.Add(new Animal("Dog1", "DoG", test.Count + 1, 4, "a dog"));
            test.Add(new Bird("Bird1", test.Count + 1, 2, "a bird", 2));
            return test;
        }
    }
}

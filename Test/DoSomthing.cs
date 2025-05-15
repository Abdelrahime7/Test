using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class DoSomthing
    {

        public event Func<int, int>? Somthing = X => X + 1;
     

      

        public void triger(Predicate<int> condition)
        {

            int x = 10;
            if (condition(x))
            {
                OnSomethinghappend(x);
            }

        }

        public void OnSomethinghappend(int x)
        {
            if (Somthing != null)
            {
                Somthing?.Invoke(x);
            }
        }
    }
}
    


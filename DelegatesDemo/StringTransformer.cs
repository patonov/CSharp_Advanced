using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class StringTransformer<T>
    {
        public void OutputValue(T InputValue)
        {
            if (InputValue == null)
            {
                Console.WriteLine("You are trying to fool me with inputing null.");
            }
            else
            {                
               Console.WriteLine($"{typeof(T)} - {InputValue}");
            }
        }

        public T ReturnTheSameThing(T InputValue) 
        {            
            Console.WriteLine($"{typeof(T)} - {InputValue}");
            return InputValue;
        }
    }
}

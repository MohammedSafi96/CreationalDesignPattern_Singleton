using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    /*
    *  Sealed ensures the class being inherited and
    *  object instantiation is restricted in the derived class
    */
    public sealed class Singleton
    {
        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton()); // Lazy loading initialization
        //private static Singleton instance = new Singleton(); // Eager loading initialization

        private static readonly object obj = new object();
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetInstance
        {
            get
            {
                // loading initialization
                //lock (obj)
                //{
                //    if (instance == null)
                //        instance = new Singleton();
                //}
                return instance.Value;
            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            Console.WriteLine("A new instance has been created!");
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;

namespace Chapter_9_exerc_3
{
    class MyClass

    {
        public int val;
    }
    struct myStruct
    {
        public int val;

    }
    class program
    {
        static void Main (string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectAB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            myStruct structA = new myStruct();
            myStruct structB = structA;
            structA.val = 30;
            structB.val = 40;
            Console.WriteLine("objectA.val = {0", objectA.val);
            Console.WriteLine("objectB.val = {0", objectB.val);
            Console.WriteLine("objectA.val = {0", structA.val);
            Console.WriteLine("objectB.val = {0", structB.val);
            Console.ReadKey();

        }
    }
      
        
            
        
    }
}

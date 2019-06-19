using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_TypeOf_GetType_SizeOf
{
    interface IGetType
    {
        void MyMethodGetType();
    }
    interface ITypeOf
    {
        void MyMethodTypeOf();
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass m = new MyDerivedClass();
            m.MyMethodGetType();
            m.MyMethodTypeOf();


            Console.ReadKey();



        }
    }
    class MyBaseClass : IGetType
    {
        public void MyMethodGetType()  // Syntax: Object.GetType()  => give us datatype in Run-Time  (Unknown)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //-----------------
            
            object MyObj = new object();            
            Console.WriteLine("object MyObj = new object(); : {0}", MyObj.GetType() + "\n");
             //-----------------
            MyBaseClass c1 = new MyBaseClass();
            Console.WriteLine("MyBaseClass myClass = new MyBaseClass(); : {0}", c1.GetType() + "\n");
            //-----------------
            MyBaseClass c2 = new MyDerivedClass();
            Console.WriteLine("MyBaseClass myBaseClass1 = new MyDerivedClass(); : {0}", c2.GetType()+"\n");
            //-----------------
            MyDerivedClass c3 = new MyDerivedClass();
            Console.WriteLine("MyDerivedClass c3 = new MyDerivedClass(); : {0}" + c3.GetType() + "\n");
            //-----------------
            Object obj2 = "is a sample text";
            Console.WriteLine("Object obj2 = 'is a sample text'; : {0}", obj2.GetType() + "\n");
             //-----------------
            string s = "is a sample text";
            Console.WriteLine("string s = 'is a sample text'; : {0}", s.GetType() + "\n");
            //-----------------
            int i = 100;
            Console.WriteLine("int i = 100; : {0}", i.GetType() + "\n");

            Console.ResetColor();
        }
    }
    class MyDerivedClass : MyBaseClass, ITypeOf
    {
        public void MyMethodTypeOf()   // Syntax: DataType.Typeof()  => give us datatype in Compile-Time (Known)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            MyBaseClass m = new MyBaseClass();
            Console.WriteLine("typeof(int); : {0}", typeof(int) + "\n");
            Console.WriteLine("typeof(MyBaseClass); : {0}", typeof(MyBaseClass) + "\n");
            Console.WriteLine("typeof(MyDerivedClass); : {0}", typeof(MyDerivedClass) + "\n");
            Console.WriteLine("typeof(IGetType); : {0}", typeof(IGetType) + "\n");
            Console.WriteLine("typeof(ITypeOf); : {0}", typeof(ITypeOf) + "\n");
            Console.ResetColor();
            //-------------------------------------------------------------------------
            // UnComment lines one by one to find GetType() - TypeOf() functionality :

            var i=100;
            //var i = 12.1f;
            //var i=12.12;
            //var i = 'C';
            //var i= "Text";

            if (i.GetType().Equals(typeof(int)))
                Console.WriteLine("You enter an integer number : {0}", i);
            else if ((i.GetType() == typeof(float)))
                Console.WriteLine("You enter a float number : {0}", i);
            else if ((i.GetType() == typeof(double)))
                Console.WriteLine("You enter a double number : {0}", i);

            else if ((i.GetType() == typeof(char)))
                Console.WriteLine("You enter a Character : {0}", i);

            else if ((i.GetType() == typeof(string)))
                Console.WriteLine("You enter a string : {0}", i);
            Console.ReadKey();
        }
    }


}

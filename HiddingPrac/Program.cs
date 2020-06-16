using System;

namespace HidingPrac
{
    class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모메서드");
            }
        }
        
        class Child : Parent
        {
            public string variable = "Hiding";
            public void Method()
            {
                Console.WriteLine("자식메서드");
            }
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine("c = " + c.variable);
            c.Method();
            Console.WriteLine("부모취급 c = " + ((Parent)c).variable);
            ((Parent)c).Method();
        }
    }
}

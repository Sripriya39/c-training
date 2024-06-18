using System;
namespace Day4_Dotnet
{
    class shape
    {
        protected float R, L, B;

        //function to calculate area of shape

        public virtual float Area() 
        public float Area()
        {
            return 3.14f * R * R;
        }
    }
    class Rectabgle : shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length :");
            L = float.Parse(Console.ReadLine());

            Console.Write("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());

        }

        public override float Area()
        {
            return L * B ();
        }
    }
    

}
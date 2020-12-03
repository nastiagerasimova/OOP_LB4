using System.Diagnostics;

namespace OOP_LB4._2nd
{
    class A
    {
        public A() { }
        public A(B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }
        public A(B b1, B b2) : this(b1, b2, null) { }

        B b1;
        B b2;
        B b3;

        public void GetXY()
        {
            if (b3 == null)
            {
                Debug.WriteLine($"Name - {b1.Name}: (x,y) = ({b1.X},{b1.Y})\n" +
                                $"Name - {b2.Name}: (x,y) = ({b2.X},{b2.Y})\n");
            }
            else
            {
                Debug.WriteLine($"Name - {b1.Name}: (x,y) = ({b1.X},{b1.Y})\n" +
                                $"Name - {b2.Name}: (x,y) = ({b2.X},{b2.Y})\n" +
                                $"Name - {b3.Name}: (x,y) = ({b3.X},{b3.Y})\n");
            }
        }

    }
}

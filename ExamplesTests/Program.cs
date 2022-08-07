using System;

namespace ExamplesTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çok doğru bir kullanım değil

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine(rectangle.calculateArea());
            
            Square square = new Square(5);
            Console.WriteLine(square.calculateArea());
           
            testAreaForRectangle(new Rectangle());
            testAreaForRectangle(new Square());
            //testAreaForSquare(new Square()); // RTTI exapmle

            Console.ReadKey();
        }


      

        public class Rectangle
        {
            protected int shortSide;
            protected int longSide;

            public Rectangle()
            {

            }

            public Rectangle(int shortSide, int longSide)
            {
                this.shortSide = shortSide;
                this.longSide = longSide;
            }

            public double calculateArea()
            {
                return shortSide * longSide;
            }

            public void setShortSide(int shortSide)
            {
                this.shortSide = shortSide;                
            }

            public void setLongSide(int longSide)
            {                
                this.longSide = longSide;
            }
        }

        public class Square : Rectangle
        {
            public Square()
            {
            }

            public Square(int side) : base(side, side)
            {
            }

            public new void setShortSide(int shortSide)
            {
                base.shortSide = shortSide;
                base.longSide = shortSide;
            }

            public new void setLongSide(int longSide)
            {
                base.shortSide = longSide;
                base.longSide = longSide;
            }
        }


        public static void testAreaForRectangle(Rectangle rectangle)
        {
            rectangle.setShortSide(5);
            rectangle.setLongSide(10);
            double expectedArea = 5.0 * 10.0;
            double realArea = rectangle.calculateArea();
            string control = expectedArea == realArea ? "Success" : "Test Failed";
            Console.WriteLine(control);
        }

        public static void testAreaForSquare(Rectangle rectangle)
        {
            if (rectangle is Square)
            {
                Square square = (Square)rectangle;
                square.setShortSide(5);
                square.setLongSide(10);
                double expectedArea = 10.0 * 10.0;
                double realArea = rectangle.calculateArea();
                string control = expectedArea == realArea ? "Success" : "Test Failed";
                Console.WriteLine(control);
            }
        }
    }
}

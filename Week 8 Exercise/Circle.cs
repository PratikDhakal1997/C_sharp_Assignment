//Author: Pratik C0899291

namespace week8
{
    class CheckCircle
    {
        static void Main()
        {
            double x1;
            double y1;
            double radius1;

            //take input x from user
            Console.Write("Enter x1 value of point: ");
            string inputX1 =  Console.ReadLine();

            //take input y from user
            Console.Write("Enter y1 value of point: ");
            string inputY1 = Console.ReadLine();

            //take input radius from user
            Console.Write("Enter radius1: ");
            string inputR1 = Console.ReadLine();

            if (!Double.TryParse(inputX1, out x1))
            {
                Console.WriteLine("Wrong input x");
            }

            if (!Double.TryParse(inputY1, out y1))
            {
                Console.WriteLine("Wrong input y");
            }

            if (!Double.TryParse(inputR1, out radius1))
            {
                Console.WriteLine("Wrong input radius");
            }

            // Use the Point constructor to assign x and y
            Point firstPoint = new Point(x1,y1);


            // Use the Circle constructor to assign point and radius
            Circle firstCircle = new Circle(firstPoint,radius1);

            firstCircle.Perimeter();
            firstCircle.Area();

            Console.WriteLine("\n");


            // SECOND CIRCLE

            double x2;
            double y2;
            double radius2;

            //take input x from user
            Console.Write("Enter x2 value of point: ");
            string inputX2 = Console.ReadLine();

            //take input y from user
            Console.Write("Enter y2 value of point: ");
            string inputY2 = Console.ReadLine();

            //take input radius from user
            Console.Write("Enter radius 2: ");
            string inputR2 = Console.ReadLine();

            if (!Double.TryParse(inputX2, out x2))
            {
                Console.WriteLine("Wrong input x");
            }

            if (!Double.TryParse(inputY2, out y2))
            {
                Console.WriteLine("Wrong input y");
            }

            if (!Double.TryParse(inputR2, out radius2))
            {
                Console.WriteLine("Wrong input radius");
            }

            // Use the Point constructor to assign x and y
            Point secondPoint = new Point(x2, y2);


            // Use the Circle constructor to assign point and radius
            Circle secondCircle = new Circle(firstPoint, radius2);

            secondCircle.Perimeter();
            secondCircle.Area();

            Console.WriteLine("\n");

            // THIRD CIRCLE

            double x3;
            double y3;
            double radius3;

            //take input x from user
            Console.Write("Enter x3 value of point: ");
            string inputX3 = Console.ReadLine();

            //take input y from user
            Console.Write("Enter y3 value of point: ");
            string inputY3 = Console.ReadLine();

            //take input radius from user
            Console.Write("Enter radius 3: ");
            string inputR3 = Console.ReadLine();

            if (!Double.TryParse(inputX3, out x3))
            {
                Console.WriteLine("Wrong input x");
            }

            if (!Double.TryParse(inputY3, out y3))
            {
                Console.WriteLine("Wrong input y");
            }

            if (!Double.TryParse(inputR3, out radius3))
            {
                Console.WriteLine("Wrong input radius");
            }

            // Use the Point constructor to assign x and y
            Point thirdPoint = new Point(x3, y3);


            // Use the Circle constructor to assign point and radius
            Circle thirdCircle = new Circle(firstPoint, radius3);



            thirdCircle.Perimeter();
            thirdCircle.Area();

            Console.WriteLine("\n");

            Circle[] circles = new Circle[] { firstCircle, secondCircle, thirdCircle };

            // take input examplary point from user
            //x
            double x;
            double y;

            //take input x from user
            Console.Write("Enter examplary x value of point: ");
            string inputX = Console.ReadLine();

            //take input y from user
            Console.Write("Enter y3 value of point: ");
            string inputY = Console.ReadLine();


            if (!Double.TryParse(inputX, out x))
            {
                Console.WriteLine("Wrong input x");
            }

            if (!Double.TryParse(inputY, out y))
            {
                Console.WriteLine("Wrong input y");
            }


            // Use the Point constructor to assign x and y
            Point examplaryPoint = new Point(x, y);

            Console.WriteLine("\n");

            // Ask each of the dogs to bark
            foreach (Circle circle in circles)
            {
                circle.checkPoint(examplaryPoint);
                Console.WriteLine("\n");
            }


        }
    }

    class Point
    {
        private double x;
        private double y;

        //constructor
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

    }

    class Circle
    {
        private Point point;
        private double radius;

        //constructor
        public Circle(Point point, double radius)
        {
            this.point = point;
            this.radius = radius;
        }

        public Point Point
        {
            get { return this.point; }
            set { this.point = value; }
        }

        public double Y
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public void Perimeter()
        {
            double perimeter = 2*3.14*this.radius;

            Console.WriteLine("Perimeter of circle with point ({0},{1}) and Radius {2} is {3}", this.point.X, this.point.Y, this.radius, perimeter);
        }

        public void Area()
        {
            double area = 3.14 * this.radius * this.radius;

            Console.WriteLine("Area of circle with point ({0},{1}) and Radius {2} is {3}", this.point.X, this.point.Y, this.radius, area);
        }

        public void checkPoint(Point ePoint)
        {
            double distance = Math.Sqrt(Math.Pow(ePoint.X - this.point.X, 2) + Math.Pow(ePoint.Y - this.point.Y, 2));

            if (distance < this.radius)
            {
                Console.WriteLine("The point lies inside the circle with ({0},{1}) point and Radius {2}", this.point.X, this.point.Y, this.radius);
            }
            else if (distance == this.radius)
            {
                Console.WriteLine("The point lies on the circle ({0},{1}) point and Radius {2}", this.point.X, this.point.Y, this.radius);
            }
            else
            {
                Console.WriteLine("The point lies outside the circle ({0},{1}) point and Radius {2}", this.point.X, this.point.Y, this.radius);
            }
        }

    }

    

}

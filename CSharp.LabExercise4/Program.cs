using System;

namespace CSharp.LabExercise4
{

    interface IShape
    {
        public decimal Area { get; set; }
        public string Name { get; set; }
        public void ComputeArea(decimal input);

        public void ComputeArea(decimal input1, decimal input2);
        public void DisplayArea();
     
    }


    class Circle : IShape
    {
        public decimal Area { get; set; }

        public string Name 
        { 
            get => "Circle" ; set { } 
        }
        
        
        public void ComputeArea(decimal radius)
        {
            decimal radiusSquared = radius * radius;
            this.Area = (decimal)Math.PI * radiusSquared;
            
        }

        public void ComputeArea(decimal input1, decimal input2) { }

        public void DisplayArea()
        {
            
            Console.WriteLine("Circle Area: {0}", this.Area); ;
        }
    }

    class Square : IShape
    {
        public decimal Area { get; set; }
        public string Name
        { 
            get => "Square"; set { }
        }

        public void ComputeArea(decimal sideLength)
        {
            this.Area = sideLength * sideLength;
        }

        public void ComputeArea(decimal input1, decimal input2) { }

        public void DisplayArea()
        {
            Console.WriteLine("Square Area: {0}", this.Area);
        }
    }

    class Rectangle : IShape
    {
        public decimal Area { get; set; }
        public string Name
        { 
            get => "Rectangle"; set { }
        }
        
        public void ComputeArea( decimal input) { }

        public void ComputeArea(decimal width, decimal length)
        {
            this.Area = width * length;
        }


        public void DisplayArea()
        {
            Console.WriteLine("Rectangle Area: {0}", this.Area);
        }
    }

    class AreaSolver
    {
        
        public void ComputeArea ( IShape shape, decimal input)
        {
            shape.ComputeArea(input);
        }

        public void ComputeArea(IShape shape, decimal input1, decimal input2)
        {
            shape.ComputeArea(input1,input2);
        }

        public void DisplayArea( IShape shape)
        {
            shape.DisplayArea();
        }
    }

    interface IArithmeticOperations
    {
        public void Compute( decimal input1, decimal input2);
    }

    class Addition : IArithmeticOperations
    {
        decimal sum;

        public void Compute(decimal input1, decimal input2)
        {
            this.sum = input1 + input2;
            Console.WriteLine("Sum is: {0}", this.sum);
        }
    }

    class Subtraction : IArithmeticOperations
    {
        decimal difference;

        public void Compute(decimal input1, decimal input2)
        {
            this.difference = input1 - input2;
            Console.WriteLine("Difference is: {0}", this.difference);
        }
    }

    class Multiplication : IArithmeticOperations
    {
        decimal product;

        public void Compute(decimal input1, decimal input2)
        {
            this.product = input1 * input2;
            Console.WriteLine("Product is: {0}", this.product);
        }
    }

    class Division : IArithmeticOperations
    {
        decimal quotient;

        public void Compute(decimal input1, decimal input2)
        {
            this.quotient = input1 / input2;
            Console.WriteLine("Quotient is: {0}", this.quotient);
        }
    }

    class Calculator
    {
        public void Compute( IArithmeticOperations operation, decimal input1, decimal input2)
        {
            operation.Compute(input1, input2);
        }
    }

    class Program
    {
        static void Number1()
        {
            
            while(true)
            {
                Console.WriteLine("*************** Welcome to AreaSolver ***************\n\n");
                Console.WriteLine("1. Circle\n");
                Console.WriteLine("2. Square\n");
                Console.WriteLine("3. Rectangle\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("******************************************************\n\n");
                Console.Write("Enter number corresponding to shape you want to solve: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (choice == 1)
                {
                    bool choice1 = true;
                    while (choice1)
                    {
                        Console.Write("Enter radius: ");
                        string rad = Console.ReadLine();
                        decimal radius;
                        bool success = decimal.TryParse(rad, out radius);
                        AreaSolver circleSolver = new AreaSolver();
                        IShape circle = new Circle();
                        circleSolver.ComputeArea(circle, radius);

                        if (success)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing AREA of {0}", circle.Name);
                            Console.WriteLine("using Radius: {0}\n", radius);
                            circleSolver.DisplayArea(circle);
                            choice1 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }
                        
                    }  
                    continue;
                }
                else if (choice == 2)
                {
                    bool choice2 = true;
                    while (choice2)
                    {
                        Console.Write("Enter sidelength: ");
                        string sideL = Console.ReadLine();
                        decimal lengthOfSide;
                        bool success = decimal.TryParse(sideL, out lengthOfSide);
                        AreaSolver squareSolver = new AreaSolver();
                        IShape square = new Square();
                        squareSolver.ComputeArea(square, lengthOfSide);

                        if (success)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing AREA of {0}", square.Name);
                            Console.WriteLine("using Sidelength: {0}\n", lengthOfSide);
                            squareSolver.DisplayArea(square);
                            choice2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 3)
                {
                    bool choice3 = true;
                    while (choice3)
                    {
                        Console.Write("Enter length: ");
                        string length = Console.ReadLine();
                        decimal realLength;
                        bool success1 = decimal.TryParse(length, out realLength);
                        Console.Write("Enter width: ");
                        string width = Console.ReadLine();
                        decimal realWidth;
                        bool success2 = decimal.TryParse(width, out realWidth);

                        AreaSolver rectangleSolver = new AreaSolver();
                        IShape rectangle = new Rectangle();
                        rectangleSolver.ComputeArea(rectangle, realLength, realWidth);

                        if (success1 == true && success2 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing AREA of {0}", rectangle.Name);
                            Console.WriteLine("using Length: {0}", realLength);
                            Console.WriteLine("using Width: {0}\n", realWidth);
                            rectangleSolver.DisplayArea(rectangle);
                            choice3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nThank you for using this AreaSolver!");
                    Console.WriteLine("Have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input!\n");
                    continue;
                }
            }


        }


        static void Number2()
        {
            while(true)
            {
                Console.WriteLine("*************** Welcome to Arithmetic Calculator ***************\n\n");
                Console.WriteLine("1. Addition\n");
                Console.WriteLine("2. Subtraction\n");
                Console.WriteLine("3. Multiplication\n");
                Console.WriteLine("4. Division\n");
                Console.WriteLine("5. Quit\n");
                Console.WriteLine("******************************************************\n\n");
                Console.Write("Enter number corresponding to operation you want to use: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (choice == 1)
                {
                    bool choice1 = true;
                    while (choice1)
                    {
                        Console.Write("Enter first addend: ");
                        string add1 = Console.ReadLine();
                        decimal addend1;
                        bool success1 = decimal.TryParse(add1, out addend1);
                        Console.Write("Enter second addend: ");
                        string add2 = Console.ReadLine();
                        decimal addend2;
                        bool success2 = decimal.TryParse(add2, out addend2);

                        Calculator calculator = new Calculator();
                        IArithmeticOperations sum = new Addition();
                        

                        if (success1 == true && success2 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing SUM of {0} + {1} \n", addend1, addend2);
                            calculator.Compute(sum, addend1, addend2);
                            choice1 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 2)
                {
                    bool choice2 = true;
                    while (choice2)
                    {
                        Console.Write("Enter minuend: ");
                        string minu = Console.ReadLine();
                        decimal minuend;
                        bool success1 = decimal.TryParse(minu, out minuend);
                        Console.Write("Enter subtrahend: ");
                        string subtra = Console.ReadLine();
                        decimal subtrahend;
                        bool success2 = decimal.TryParse(subtra, out subtrahend);

                        Calculator calculator = new Calculator();
                        IArithmeticOperations difference = new Subtraction();


                        if (success1 == true && success2 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing DIFFERENCE of {0} - {1} \n", minuend, subtrahend);
                            calculator.Compute(difference, minuend, subtrahend);
                            choice2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 3)
                {
                    bool choice3 = true;
                    while (choice3)
                    {
                        Console.Write("Enter first factor: ");
                        string fact1 = Console.ReadLine();
                        decimal factor1;
                        bool success1 = decimal.TryParse(fact1, out factor1);
                        Console.Write("Enter second factor: ");
                        string fact2 = Console.ReadLine();
                        decimal factor2;
                        bool success2 = decimal.TryParse(fact2, out factor2);

                        Calculator calculator = new Calculator();
                        IArithmeticOperations product = new Multiplication();


                        if (success1 == true && success2 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing PRODUCT of {0} * {1} \n", factor1, factor2);
                            calculator.Compute(product, factor1, factor2);
                            choice3 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 4)
                {
                    bool choice4 = true;
                    while (choice4)
                    {
                        Console.Write("Enter dividend: ");
                        string divi1 = Console.ReadLine();
                        decimal dividend;
                        bool success1 = decimal.TryParse(divi1, out dividend);
                        Console.Write("Enter divisor: ");
                        string divi2 = Console.ReadLine();
                        decimal divisor;
                        bool success2 = decimal.TryParse(divi2, out divisor);

                        Calculator calculator = new Calculator();
                        IArithmeticOperations quotient = new Division();


                        if (success1 == true && success2 == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Computing QUOTIENT of {0} / {1} \n", dividend, divisor);
                            calculator.Compute(quotient, dividend, divisor);
                            choice4 = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input. Please input numbers only.");
                        }

                    }
                    continue;
                }
                else if (choice == 5)
                {
                    Console.WriteLine("\nThank you for using this Arithmetic Calculator!");
                    Console.WriteLine("Have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input!\n");
                    continue;
                }
            }
        }

        static void Main(string[] args)
        {
            //Number1();
            //Number2();
        }
    }
}

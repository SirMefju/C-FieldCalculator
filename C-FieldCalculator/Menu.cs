using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FieldCalculator
{
    public class Menu
    {
        public static int menu()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-         MAIN MENU         -");
            Console.WriteLine("1.   Field of square.");
            Console.WriteLine("2.   Field of rectangle.");
            Console.WriteLine("3.   Field of triangle.");
            Console.WriteLine("4.   Field of circle.");
            Console.WriteLine("5.   Exit.");
            Console.WriteLine("-----------------------------");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static void choose()
        {
            int choice = menu();
            if (choice == 1)
            {
                Console.WriteLine("Tell me about square frame size:");
                double a = Convert.ToDouble(Console.ReadLine());
                double squareArea = a * a;
                double squarePerimeter = 4 * a;
                Console.WriteLine("The area of the square is equal = " + squareArea);
                Console.WriteLine("The perimeter of the square is equal = " + squarePerimeter);
                Menu.choose();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Tell me about rectangle first frame size:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Tell me about rectangle second frame size:");
                double b = Convert.ToDouble(Console.ReadLine());
                double rectangleArea = a * b;
                double rectanglePerimeter = 2 * a + 2 * b;
                Console.WriteLine("The area of the rectangle is equal = " + rectangleArea);
                Console.WriteLine("The perimeter of the rectangle is equal = " + rectanglePerimeter);
                Menu.choose();
            }
            else if (choice == 3)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Equilateral triangle.");
                Console.WriteLine("2.   Regular triangle.  ");
                Console.WriteLine("3.     Back to menu.    ");
                Console.WriteLine("------------------------");
                double y = Convert.ToDouble(Console.ReadLine()); ;
                if (y == 1)
                {
                    Console.WriteLine("Tell me about triangle frame size:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = (a * a * (Math.Pow(3, 0.5))) / 4;
                    double trianglePerimeter = 3 * a;
                    double triangleHeight = (a * (Math.Pow(3, 0.5))) / 2;
                    Console.WriteLine("The area of the rectangle is equal = " + triangleArea);
                    Console.WriteLine("The perimeter of the rectangle is equal = " + trianglePerimeter);
                    Console.WriteLine("The height of the rectangle is equal = " + triangleHeight);
                    Menu.choose();
                }
                else if (y == 2)
                {
                    Console.WriteLine("Tell me about triangle base size:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tell me about triangle first frame size:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tell me about triangle second frame size:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Tell me about triangle height size:");
                    double h = Convert.ToDouble(Console.ReadLine());
                    double triangleArea = 0.5 * a * h;
                    double trianglePerimeter = a + b + c;
                    Console.WriteLine("The area of the rectangle is equal = " + triangleArea);
                    Console.WriteLine("The perimeter of the rectangle is equal = " + trianglePerimeter);
                    Menu.choose();
                }
                else if (y == 3)
                    Menu.choose();
                else
                {
                    Console.WriteLine("Wrong choice try again.");
                    Menu.choose();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Tell me about radius of the circle:");
                double r = Convert.ToDouble(Console.ReadLine());
                double circleArea = Math.PI * r * r;
                double circlePerimeter = 2 * Math.PI * r;
                Console.WriteLine("The area of the circle is equal = " + circleArea);
                Console.WriteLine("The perimeter of the circle is equal = " + circlePerimeter);
                Menu.choose();
            }
            else if (choice == 5)
                System.Environment.Exit(0);
            else
            {
                Console.WriteLine("Wrong choice try again.");
                Menu.choose();
            }
        }
    }
}

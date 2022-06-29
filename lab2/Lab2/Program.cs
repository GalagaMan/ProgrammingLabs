using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace Lab2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[2];
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"Set up {i+1} Rectangle");
                Console.ReadLine();
                Console.WriteLine($"Input {i+1} X of init. vertex");

                float x = float.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"Input {i+1} Y of init. vertex");
                float y = float.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"Input {i+1} width");
                float width = float.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"Input {i+1} height");
                float height = float.Parse(Console.ReadLine());
                Console.Clear();

                rectangles[i] = new Rectangle(x, y, width, height);

            }

            try
            {
                while (true)
                {
                    int rectangle;
                    string filePath;
                    Console.WriteLine("input command");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "set width":
                            Console.WriteLine("input desired rectangle: ");
                            rectangle = int.Parse(Console.ReadLine());
                            rectangles[rectangle - 1].SetWidth(float.Parse(Console.ReadLine()));
                            Console.WriteLine("width set");
                            break;
                        case "set height":
                            Console.WriteLine("input desired rectangle: ");
                            rectangle = int.Parse(Console.ReadLine());
                            rectangles[rectangle - 1].SetHeight(float.Parse(Console.ReadLine()));
                            Console.WriteLine("height set");
                            break;
                        case "move rectangle":
                            Console.WriteLine("input desired rectangle: ");
                            rectangle = int.Parse(Console.ReadLine());
                            float x, y;
                            Console.WriteLine("input x y values to move rectangle by");
                            x = float.Parse(Console.ReadLine());
                            y = float.Parse(Console.ReadLine());
                            rectangles[rectangle - 1].MoveRectangle(x, y);
                            break;
                        case "build rect":
                            var rec = Rectangle.BuildSmallestRectangle(rectangles[0], rectangles[1]);
                            rec.CheckVertices();
                            break;
                        case "write json":
                            Console.WriteLine("input desired rectangle: ");
                            rectangle = int.Parse(Console.ReadLine());
                            Console.WriteLine("input file path");
                            filePath = Console.ReadLine();
                            rectangles[rectangle - 1].ToJson(filePath);
                            break;
                        case "read json":
                            Console.WriteLine("input desired rectangle: ");
                            rectangle = int.Parse(Console.ReadLine());
                            Console.WriteLine("input file path");
                            filePath = Console.ReadLine();
                            rectangles[rectangle - 1] = Rectangle.FromJson(filePath);
                            rectangles[rectangle -1].SetVertices();
                            break;
                        default:
                            Console.WriteLine("unknown input");
                            break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("input cannot be null");
            }
        }
    }
}

using System;

namespace FillSpheres
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 14);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 21);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 420);

            Console.WriteLine("Your Spheres:");
            Console.WriteLine("Sphere 1: color = [{0}, {1}, {2}], radius = {3}", 
            sphere1.Color.Red, sphere1.Color.Green, sphere1.Color.Blue, 
            sphere1.Radius);
            Console.WriteLine("Sphere 2: color = [{0}, {1}, {2}], radius = {3}", 
            sphere2.Color.Red, sphere2.Color.Green, sphere2.Color.Blue, 
            sphere2.Radius);
            Console.WriteLine("Sphere 3: color = [{0}, {1}, {2}], radius = {3}", 
            sphere3.Color.Red, sphere3.Color.Green, sphere3.Color.Blue, 
            sphere3.Radius);

            // Toss spheres back and forth
            const int numTosses = 5;
            for (int i = 0; i < numTosses; i++)
            {
                if (i % 2 == 0)
                {
                    sphere1.Throw();
                    sphere2.Pop();
                }
                else
                {
                    sphere1.Pop();
                    sphere2.Throw();
                }

                sphere3.Throw();
                Console.WriteLine("After toss number {0}:", i + 1);
                Console.WriteLine("Sphere 1: color = [{0}, {1}, {2}], radius = {3}, times thrown = {4}", 
                sphere1.Color.Red, sphere1.Color.Green, sphere1.Color.Blue, 
                sphere1.Radius, sphere1.GetTimesThrown());
                Console.WriteLine("Sphere 2: color = [{0}, {1}, {2}], radius = {3}, times thrown = {4}", 
                sphere2.Color.Red, sphere2.Color.Green, sphere2.Color.Blue, 
                sphere2.Radius, sphere2.GetTimesThrown());
                Console.WriteLine("Sphere 3: color = [{0}, {1}, {2}], radius = {3}, times thrown = {4}", 
                sphere3.Color.Red, sphere3.Color.Green, sphere3.Color.Blue, 
                sphere3.Radius, sphere3.GetTimesThrown());
                Console.WriteLine("Color name: {0}", new Color(255, 0, 0).Name);
                Console.WriteLine("Color name: {0}", new Color(0, 255, 0).Name);
                Console.WriteLine("Color name: {0}", new Color(0, 0, 255).Name);
            }
        }
    }
}

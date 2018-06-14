    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace IntersectionOfArrays
    {
        class Program
        {
            static void Main(string [] args )
            {
                Console.Write("Enter the size of the first array : ");

                int n = int.Parse(Console.ReadLine());
                int[] array1 = new int[n];

                Console.WriteLine("");
                Console.WriteLine("***************************************");
                Console.WriteLine("");
                Console.Write("Enter the size of the second array : ");

                int m = int.Parse(Console.ReadLine());
                int[] array2 = new int[m];

                Console.WriteLine("");
                Console.WriteLine("***************************************");
                Console.WriteLine("");

                for (int i = 0; i < n; i++)
                {
                Console.Write("Enter the values for the first array : ");
                array1[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("");
                Console.WriteLine("***************************************");
                Console.WriteLine("");

                for (int j = 0; j < m; j++)
                {
                Console.Write("Enter the values for the second array : ");
                array2[j] = int.Parse(Console.ReadLine());
                }

                
                Console.WriteLine("***************************************");
                // Call Intersect extension method.
                var intersect = array1.Intersect(array2);
                // Write intersection to screen.
                foreach (int value in intersect)
                {
                Console.WriteLine("The intersection of the two arrays are these numbers:" + value);
                }

        }

        }
    }

using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 211, 9, -6, 12, 34, 56, 32, 5, 19 };
            int[] arr2 = { 19, -6, 32 ,10};
            bool result = false;
            int counter = 0;
            foreach (int elem1 in arr1)
                foreach (int elem2 in arr2)
                {

                    if (elem2 == elem1)
                    {
                        counter++;
                  
                        if (counter==arr2.Length)
                        {
                            result = true;
                        }
  }
 }
            Console.WriteLine(result);
        }
    }
}

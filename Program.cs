using System;
using System.Collections;

namespace JaggedArrays
{
    class Program
    {

        static void Main(string[] args)
        {
            // declaring ArrayLists with undefined no. of objects
            ArrayList myArrayList = new ArrayList();

            // declaring ArrayLists with defined no. of objects

            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(15);
            myArrayList.Add("Hello");
            myArrayList.Add("World");
            myArrayList.Add(1.439d);
            myArrayList.Add(67.5d);
            myArrayList.Add(100);
            myArrayList.Add(340);

            // delete element with specific value from an arraylist
            myArrayList.Remove(100);
            myArrayList.Remove(100); // this does not throws any error, 100 is already removed
            myArrayList.Remove(100); // this does not throws any error, 100 is already removed

            //delete via index
            myArrayList.RemoveAt(0);

            // total no. of elements of arrayList
            System.Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj; // cast object into double
                }
                else
                {
                    System.Console.WriteLine(obj);
                }
            }
            System.Console.WriteLine("total sum of myArrayList is " + sum);

        }


    }
}
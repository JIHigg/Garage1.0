using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Garage1._0
{
    public class Garage<T>: IEnumerable<T> where T : Vehicle 
    {


        private int i = 0;
        private T[] g= new T[4];

        public T[] G { get => g; set => g = value; }
        public int I { get => i; set => i = value; }

        public Array GetGarage()
        {
            return G;
        }
        public Vehicle GetVehicle(T vehicle)
        {
            var V = Array.Find(G, ele => ele.GetType() == vehicle.GetType());
            
            
            
            return V;
        }



        public Garage()
        {

        }
        public Garage(int size)
        {
            Array.Resize<T>(ref g, (Math.Max(0,size)));
           
        }
        public void AddVehicle(T vehicle)
        {
            
            G[I] = vehicle;
            I++;
            //throw new NotImplementedException();
        }

        public void OutVehicle(T vehicle)
        {
            
        }
        public void DisplayGarage()
        {
            Console.Clear();
            Console.WriteLine("Here's what you have parked in the Garage right now:" +
                              "\nGarage" +
                              "\n------------------");
            for (int n = 0; n < G.Length; n++)
               if(G[n] != null) Console.WriteLine($"{n+1}. " + G[n].Name + " : " + G[n].Model);

            

            Console.WriteLine("------------------");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)G).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return G.GetEnumerator();
        }
    }
}

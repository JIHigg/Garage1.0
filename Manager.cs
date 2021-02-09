using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class Manager
    {
        GarageManager GM = new GarageManager();
        public void Start()
        {
            bool open = true;
            while (open)
            {
                GM.Menu();//User Menu
            }
        }

        public  Manager()
        {
            
        }
    }
}

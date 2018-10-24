using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15OrangeTree
{
    public class OrangeTree
    {

        public OrangeTree(int age, int height)
        {
            Age = age;
            Height = height;
            
        }

        public int Age
        {
            get;
            private set;
            
        }

        public bool TreeAlive
        {
         get;
         private set;
        }
           
        

        public int Height
        {
            get;

            private set;
            
        }
        
        public int OrangesEaten
        {
            get;
            private set;
        }


        public int NumOranges
        {
          get;
          private set;
        }
        public void EatOrange(int v)
        {
            if (Age >= 2 && Age >= 80)
            {
                v =+ v + 1;
            }
            else
            {
                throw Exception ""
            }
        }


        public void OneYearPasses()
        {
            Age =+ Age + 1;
            
            if (Age >= 1 && Age <= 80)
            {
                Height =+ Height + 2;
            }
            else
            {
                Height = 164;
            }

            if (Age >= 2 && Age <= 80)
            {
                NumOranges =+ NumOranges + 5;
            }
            else
            {
                NumOranges = 0;
            }



            



        }
        


    }
}








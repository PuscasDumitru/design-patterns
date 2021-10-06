using System;
using System.Collections.Generic;
using System.Text;

namespace patterns
{
    public class RandomNonBuyers
    {
        static RandomNonBuyers instance;
        List<string> nonBuyers = new List<string>();
        Random random = new Random();
        
        private static object locker = new object();
        
        protected RandomNonBuyers()
        {

            nonBuyers.Add("Buyer Sam walking around...Still doesn't want to buy something");
            nonBuyers.Add("Buyer Dave is wondering how fast is this moto, but he still got no money");
            nonBuyers.Add("Buyer Linda always wanted a red car, but the last one just got out of stock...");
            nonBuyers.Add("Buyer Tim entered just to use the bathroom...");
            
        }
        public static RandomNonBuyers GetRandomNonBuyers()
        {
         
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new RandomNonBuyers();
                    }
                }
            }
            return instance;
        }
       
        public string NonBuyer
        {
            get
            {
                int r = random.Next(nonBuyers.Count);
                return nonBuyers[r].ToString();
            }
        }
    }
}

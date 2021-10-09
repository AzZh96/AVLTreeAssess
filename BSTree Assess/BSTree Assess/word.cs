using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree_Assess
{
    class word : IComparable
    {
        int counter = 0;
        public string words;
        
        
        public word(string words)
        {
            this.words = words;
            //this.counter = counters;
        }

        public int Counter
        {
            get { return this.counter;  }
            set { this.counter = value; }
        }

        public string Words 
        {
            get { return this.words; }
            set { this.words = value; }
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            word other = (word)obj;
            return words.CompareTo(other.words);
        }





    }
}

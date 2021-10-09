using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BSTree_Assess
{
    class Program
    {
        static AVLTree<word> AVLTree = new AVLTree<word>();
        static BSTree<string> BSTree = new BSTree<string>();
        
        
        static void readFile(string fileName)
        {
            //word lineword = new word();
            //lineword.Words = "";
            const int MAX_FILE_LINES = 50000;
            string[] AllLines = new string[MAX_FILE_LINES];

            //reads from bin/DEBUG subdirectory of project directory
                        
            AllLines = File.ReadAllLines(fileName);
            
            foreach (string line in AllLines)
            {
                //split words using space , . ?
                string[] arraywords = line.Split(' ', ',', '.', '?', ';', ':', '!');
                foreach (string wordline in arraywords)
                    if (wordline != "")
                        AVLTree.InsertItem(wordline.ToLower());
             
                   
            }
        }

        static void Main(string[] args)
        {
            readFile("textFile.txt");
            string buffer = "";
            AVLTree.PreOrder(ref buffer);
            //BSTree.PreOrder(ref buffer);
            Console.WriteLine("Pre Order: " + buffer);
            Console.WriteLine("The Number of unique words in the tree is: " + AVLTree.Count());
            Console.WriteLine("The Height of the tree is : " + AVLTree.Height());
            //Console.WriteLine("The Number of unique words in the tree is: " + BSTree.Count());
            //Console.WriteLine("The Height of the tree is : " + BSTree.Height());
            Console.ReadKey();
        }


    }
}

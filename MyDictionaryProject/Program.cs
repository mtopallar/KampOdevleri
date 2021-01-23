using System;


namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> namelist = new MyDictionary<int, string>();

            namelist.Add(1,"Murat");
            namelist.Add(2,"Engin");
            

            Console.WriteLine(namelist.Count);

        }
        
    }
    
}

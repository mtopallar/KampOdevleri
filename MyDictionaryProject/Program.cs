using System;


namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> nameList = new MyDictionary<int, string>();

            nameList.Add(1,"Murat");
            nameList.Add(2,"Engin");
            

            Console.WriteLine(nameList.Count);

        }
        
    }
    
}

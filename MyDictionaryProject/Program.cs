using System;


namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> Isimler = new MyDictionary<int, string>();

            Isimler.Add(1,"Murat");
            Isimler.Add(2,"Engin");
            

            Console.WriteLine(Isimler.Count);

        }
        
    }
    
}

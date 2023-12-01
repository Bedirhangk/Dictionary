using System.Diagnostics;

namespace Dictionary;

class Program
{
    static void Main(string[] args)
    {
        //System.Collection.Generic
        //Dictionary KEY-VALUE pair ieklinde çalışır.
        // Dictionary<KEY,VALUE> NESNE İSMİ = new Dictionary<KEY,VALUE>();
        //Valuelar aynı olabilir ancak keyler uniqe olmalıdır.
        Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

        kullanicilar.Add(10,"Bedirhan Gökkaya");
        kullanicilar.Add(16,"Barış Gökkaya");
        kullanicilar.Add(65,"Meral Tanzi");
        kullanicilar.Add(21,"Büsra Yön");
        //kullanicilar.Add(65,"Bedirhan Gökkaya"); aynı key olduğundan ekleyemezsin.
        kullanicilar.Add(11,"Bedirhan Gökkaya");


        //Dizinin Elemanlarına erişim
        Console.WriteLine("-----------Elemanlara Erişim---------------");
        Console.WriteLine();
        Console.WriteLine(kullanicilar[21]);
        Console.WriteLine();

        foreach (var a in kullanicilar)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine();

        //Count
        Console.WriteLine("---------------Counbt Alma--------------");
        Console.WriteLine(kullanicilar.Count());
        Console.WriteLine();

        //Contains
        Console.WriteLine("------------------Contains İşlemi---------------------");
        Console.WriteLine(kullanicilar.ContainsKey(10));
        Console.WriteLine(kullanicilar.ContainsValue("Umut Yasin Gürtürk"));
        Console.WriteLine();

        //Remove
        Console.WriteLine("-----------------Remove-----------------");
        kullanicilar.Remove(11);
        foreach (var b in kullanicilar)
        {
            Console.WriteLine(b);
            Console.WriteLine("Sadece Key: "+b.Key);
            Console.WriteLine("Sadece Value: "+b.Value);
            Console.WriteLine();
        }
        Console.WriteLine();

        //KEYS
        Console.WriteLine("------------------Keys-----------------");
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //VALUE
        Console.WriteLine("------------------Values-----------------");
        foreach (var item in kullanicilar.Values )
        {
            Console.WriteLine(item);
        }
    }
}

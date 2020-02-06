using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Task3_BootcampRefactory
{

    //class User1
    //{
    //    public string Id { get; set; }
    //    public string Username { get; set; }
    //    public Profile Profile { get; set; }
    //    public List<Article> Articles { get; set; }

    //}

    //class Profile
    //{
    //    public string Full_name { get; set; }
    //    public string Birthday { get; set; }
    //    public List<string> Phones { get; set; }
    //}

    //class Article
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public string Published_at { get; set; }
    //}

    //class User2
    //{
    //    public string Order_id { get; set; }
    //    public string Created_at { get; set; }
    //    public Customer Customer { get; set; }
    //    public List<Items> Items { get; set; }
    //}

    //class Customer
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    //class Items
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Qty { get; set; }
    //    public int Price { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Soal1.PhoneNumber();
            //Soal1.hasArticles();
            //Soal1.hasAnnis();
            //Soal1.year2020();
            //Soal1.Born86();
            //Soal1.hasTips();
            //Soal2.madeInFeb();
            //Soal2.purchaseAri();
            //Soal2.lowerThan();
            Soal3.MeetingRoom();
            Soal3.electronicDevice();
            Soal3.furnitures();

        }
    }

    //public class Soal1
    //{
    //    public static void PhoneNumber()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //                if (k.Profile.Phones.Count == 0)
    //                {
    //                    hasil.Add(k.Profile.Full_name);
    //                }
                
    //        }
    //        Console.WriteLine(String.Join(",",hasil));
    //    }

    //    public static void hasArticles()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //                if (k.Articles.Count != 0)
    //                {
    //                    hasil.Add(k.Profile.Full_name);
    //                }
    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void hasAnnis()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //                var A = k.Profile.Full_name.ToLower();
    //                if (A.Contains("annis"))
    //                {
    //                    hasil.Add(k.Profile.Full_name);
    //                }
  
    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void year2020()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //            foreach(var l in k.Articles)
    //            {
    //                if ((l.Published_at).Contains("2020"))
    //                {
    //                    hasil.Add(k.Profile.Full_name);
    //                }
    //                else
    //                {
    //                    hasil.Add(" ");
    //                }
    //            }
                
    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void Born86()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //            if (k.Profile.Birthday.Contains("1986"))
    //            {
    //                hasil.Add(k.Profile.Full_name);
    //            }

    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void hasTips()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //            foreach (var l in k.Articles)
    //            {
    //                if (((l.Title).ToLower()).Contains("tips"))
    //                {
    //                    hasil.Add(l.Title);
    //                }
    //            }

    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void publish2019()
    //    {
    //        string json1 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Satuu.json");
    //        var data1 = JsonConvert.DeserializeObject<List<User1>>(json1);

    //        List<string> hasil = new List<string>();
    //        foreach (var k in data1)
    //        {
    //            foreach (var l in k.Articles)
    //            {
    //                var A = Convert.ToInt32((l.Published_at).Substring(0,4));
    //                var B = Convert.ToInt32((l.Published_at).Substring(6, 2));
    //                if (A == 2019 && B < 8)
    //                {
    //                    hasil.Add(l.Title);
    //                }
    //                else if(B < 2019)
    //                {
    //                    hasil.Add(l.Title);
    //                }
    //            }

    //        }
    //        Console.WriteLine(String.Join(" ", hasil));
    //    }

    //}

    //public class Soal2
    //{
    //    public static void madeInFeb()
    //    {
    //        string json2 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Dua.json");
    //        var data2 = JsonConvert.DeserializeObject<List<User2>>(json2);

    //        List<string> hasil = new List<string>();

    //        foreach (var k in data2)
    //        {
    //            var A = Convert.ToInt32((k.Created_at).Substring(5, 2));
    //            if (A == 2)
    //            {
    //                hasil.Add(k.Order_id);
    //            }
    //        }
    //        Console.WriteLine(String.Join(",", hasil));
    //    }

    //    public static void purchaseAri()
    //    {
    //        string json2 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Dua.json");
    //        var data2 = JsonConvert.DeserializeObject<List<User2>>(json2);

    //        int grandTotal = 0;
    //        foreach(var k in data2)
    //        {
    //            foreach(var l in k.Items)
    //            {
    //                if(k.Customer.Name == "Ari")
    //                {
    //                    grandTotal += (l.Price * l.Qty);
    //                }
    //            }
    //        }
    //        Console.WriteLine(grandTotal);
    //    }

    //    public static void lowerThan()
    //    {
    //        string json2 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Dua.json");
    //        var data2 = JsonConvert.DeserializeObject<List<User2>>(json2);

    //        int grandTotalAri = 0;
    //        int grandTotalRirin = 0;
    //        int grandTotalAnnis = 0;
    //        List<string> Nama = new List<string>();
    //        foreach (var k in data2)
    //        {
    //            foreach (var l in k.Items)
    //            {
    //                if (k.Customer.Name == "Ari")
    //                {
    //                    grandTotalAri += (l.Price * l.Qty);
    //                }
    //                else if (k.Customer.Name == "Ririn")
    //                {
    //                    grandTotalRirin+= (l.Price * l.Qty);
    //                }
    //                else if (k.Customer.Name == "Annis")
    //                {
    //                    grandTotalAnnis += (l.Price * l.Qty);
    //                }
    //            }
    //        }
    //        if (grandTotalAri < 300000)
    //        {
    //            Nama.Add("Ari");
    //        }
    //        else if (grandTotalRirin < 300000)
    //        {
    //            Nama.Add("Ririn");
    //        }
    //        else if (grandTotalAnnis < 300000)
    //        {
    //            Nama.Add("Annis");
    //        }
    //        Console.WriteLine(String.Join(",",Nama));
    //    }
    //}

    public class Soal3
    {
        public static void MeetingRoom()
        {
            string json3 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Tiga.json");
            var data3 = JsonConvert.DeserializeObject<List<User3>>(json3);

            List<string> hasil = new List<string>();
            foreach(var k in data3)
            {
                if(k.Placement.Name == "Meeting Room")
                {
                    hasil.Add(k.Name);
                }
            }
            Console.WriteLine(String.Join(", ", hasil));


        }

        public static void electronicDevice()
        {
            string json3 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Tiga.json");
            var data3 = JsonConvert.DeserializeObject<List<User3>>(json3);

            List<string> hasil = new List<string>();
            foreach (var k in data3)
            {
                if (k.Type == "electronic")
                {
                    hasil.Add(k.Name);
                }
            }
            Console.WriteLine(String.Join(", ", hasil));


        }

        public static void furnitures()
        {
            string json3 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Tiga.json");
            var data3 = JsonConvert.DeserializeObject<List<User3>>(json3);

            List<string> hasil = new List<string>();
            foreach (var k in data3)
            {
                if (k.Type == "furniture")
                {
                    hasil.Add(k.Name);
                }
            }
            Console.WriteLine(String.Join(", ", hasil));
        }

        //public static void purchased()
        //{
        //    string json3 = File.ReadAllText(@"/Users/user/Projects/Task3_BootcampRefactory/Task3_BootcampRefactory/Tiga.json");
        //    var data3 = JsonConvert.DeserializeObject<List<User3>>(json3);

        //    List<string> hasil = new List<string>();
        //    foreach (var k in data3)
        //    {
        //        DateTime dt = DateTime.Parse(k.Purchased_at.ToString());
        //        string formatDT = dt.
        //        if (dt == "electronic")
        //        {
        //            hasil.Add(k.Name);
        //        }
        //    }
        //    Console.WriteLine(String.Join(", ", hasil));


        //}

    }

    class User3
    {
        public int Inventory_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<string> Tags { get; set; }
        public int Purchased_at { get; set; }
        public Placement Placement { get; set; }
    }
    class Placement
    {
        public string Name { get; set; }
        public int Room_id { get; set; }
    }
}

using System;
using System.Linq;
using _14._9._2021.Model;
namespace _14._9._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            
            entity_demoContext db = new entity_demoContext();
            //var s = (from p in db.Svs select new { p.Mssv,p.Name,p.IdLopNavigation.NameLop}).ToList();
            //var s = (db.Svs.Select(p=>new { p.Mssv,p.Name})).ToList();
            // var s = (from p in db.Svs where p.Name == "NVA"
            //         select new { p.Mssv,p.Name}).ToList();
            // var s = db.Svs.Where(p=>p.Name=="NVA").Select(p=> new { p.Mssv,p.Name}).ToList();

            //Add
            // Sv s1 = new Sv
            // {
            //     Mssv = "102180123",
            //     Name = "NVA",
            //     Dtb = 8,
            //     IdLop= 1
            // };
            // db.Add(s1);
            // db.SaveChanges();

            //Delete
            // Sv e = db.Svs.Find("102180123");
            // db.Svs.Remove(e);
            // db.SaveChanges();


            //Edit
            // Sv e = db.Svs.Find("102");
            // e.Dtb = 10;
            // db.SaveChanges();
            foreach (Sv i in db.Svs)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}

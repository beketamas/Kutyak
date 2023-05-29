using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Kutyak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2. feladat
            List<Kutyak> KutyaNevek = File.ReadAllLines("..//..//..//Adatok//KutyaNevek.csv").Skip(1).Select(x => new Kutyak(x,false)).ToList();
            //3. feladat
            Console.WriteLine($"3. feladat: {KutyaNevek.Count}");

            //6. feladat
            List<Kutyak> kutyak = File.ReadAllLines("..//..//..//Adatok//Kutyak.csv").Skip(1).Select(x => new Kutyak(x)).ToList();
            Console.WriteLine($"6. feladat: {kutyak.Average(x => x.Eletkor):f2}");

            List<Kutyak> kutyaFajtak = File.ReadAllLines("..//..//..//Adatok//KutyaFajtak.csv").Skip(1).Select(x => new Kutyak(x,true)).ToList();

            //7. feladat
            int eletkor_id = kutyak.OrderByDescending(x => x.Eletkor).ToList()[0].Fajta_id;
            int id = kutyak.OrderByDescending(x => x.Eletkor).ToList()[0].Nev_id;
            string fajta = kutyaFajtak.Where(x => x.Id == eletkor_id).ToList()[0].Nev;
            string nev = KutyaNevek.Where(x => x.Id == id).ToList()[0].KutyaNev;
            Console.WriteLine($"7. feladat: Legidősebb kutya neve és fajtája: {nev}, {fajta}");

            //8. feladat
            var id_lista = kutyak.Where(x => Regex.IsMatch(x.Utolso_orvosi,"2018.01.10"));

            //9. feladat
            var orvosi_idopont_lista = kutyak.GroupBy(x => x.Utolso_orvosi).OrderByDescending(x => x.Count()).ToList().First();
            Console.WriteLine($"9. feladat: Legjobban leterhelt nap: {orvosi_idopont_lista.Key}: {orvosi_idopont_lista.Count()}");


            //10. feladat


        }
    }
}
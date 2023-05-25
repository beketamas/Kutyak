namespace Kutyak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2. feladat
            List<string> KutyaNevek = File.ReadAllLines("..//..//..//Adatok//KutyaNevek.csv").Skip(1).Select(x => x.Split(";")[1]).ToList();
            //3. feladat
            Console.WriteLine($"3. feladat: {KutyaNevek.Count}");


        }
    }
}
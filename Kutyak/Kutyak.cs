using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class Kutyak
    {
        int id;
        int fajta_id;
        int nev_id;
        int eletkor;
        string utolso_orvosi;
        string nev;
        string eredeti_Nev;
        string kutyaNev;


        public Kutyak(string sor)
        {
            string[] tomb = sor.Split(";");
            this.id = int.Parse(tomb[0]);
            this.fajta_id = int.Parse(tomb[1]);
            this.nev_id = int.Parse(tomb[2]);
            this.eletkor = int.Parse(tomb[3]);
            this.utolso_orvosi = tomb[4];
        }

        public Kutyak(string sor, bool c) 
        {
            if (c == true)
            {
                string[] tomb = sor.Split(";");
                this.id = int.Parse(tomb[0]);
                this.nev = tomb[1];
                this.eredeti_Nev = tomb[2];
            }
            else if(c == false)
            {
                string[] tomb = sor.Split(";");
                this.id = int.Parse(tomb[0]);
                this.kutyaNev = tomb[1];
            }
            
        }



        public int Id { get => id;}
        public int Fajta_id { get => fajta_id;}
        public int Nev_id { get => nev_id;}
        public int Eletkor { get => eletkor;}
        public string Utolso_orvosi { get => utolso_orvosi;}
        public string Nev { get => nev;}
        public string Eredeti_Nev { get => eredeti_Nev;}
        public string KutyaNev { get => kutyaNev;}
    }
}

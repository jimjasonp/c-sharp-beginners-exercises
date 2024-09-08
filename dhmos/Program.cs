using System;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;

class Dhmos
{
    static void Main(string[] args)
    {
        double km , kost_nerou, tel_poso, kost_sunt , fpa;

        double i = 0;

        while (i >=0){

            Console.Write("Dwse thn katanalwsh se km: ");
            km = int.Parse(Console.ReadLine());
            while (km<0){
                Console.WriteLine("Ta km de ginetai na einai arnitika");
                Console.WriteLine("Dwse thn katanalwsh se km: ");
                km = int.Parse(Console.ReadLine());
            }
            


            if(km<=40){
                kost_nerou = km * 0.85;
            }
            else if(km<=50){
                kost_nerou = 40*0.85 +(km-40)*1.15;
            }
            else {
                kost_nerou = 40*0.85 +10*1.15+ (km-50)*1.75;
            }
            kost_sunt= kost_nerou*0.15;

            fpa = 0.13*kost_nerou;
            

            tel_poso = kost_nerou+kost_sunt+fpa;

            Console.WriteLine("to teliko poso einai:  "+tel_poso);

  



        }

       
    }
}

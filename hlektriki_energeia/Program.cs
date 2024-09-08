using System;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;

class Energeia
{
    static void Main(string[] args)
    {
        double afm , kwh, tel_poso, pagio ,kost, teli, fpa,n_customers,total_poso,i ;

        pagio = 50;
        n_customers = 0;
        total_poso = 0;
        i = 0;


        while (i >=0){

            Console.Write("Dwse to afm sou: ");
            afm = int.Parse(Console.ReadLine());
            while (afm<0){
                Console.WriteLine("To afm de ginetai na einai arnitiko");
                Console.WriteLine("Dwse to afm sou: ");
                afm = int.Parse(Console.ReadLine());
            }
            


            Console.Write("Posi katanalosi exeis se kwh? ");
            kwh = int.Parse(Console.ReadLine());
            while (kwh<0){
                Console.WriteLine("To kwh de ginetai na einai arnitiko");
                Console.WriteLine("Posi katanalosi exeis se kwh? ");
                afm = int.Parse(Console.ReadLine());
            }


            if(kwh<=2000){
                kost = kwh * 0.28;
            }
            else if(kwh<=3200){
                kost = 2000*0.28 +(kwh-2000)*0.35;
            }
            else {
                kost = 2000*0.28 + 1200*0.35 + (kwh-3200)*0.15;
            }

            teli = 0.05*kost;
            fpa = 0.24*kost;
            

            tel_poso = pagio+kost+teli+fpa;

            Console.WriteLine("to teliko poso einai:  "+tel_poso);

            total_poso = total_poso+tel_poso;
            n_customers = n_customers+1;

            Console.WriteLine("Theleis na sunexisw gia ton epomeno pelati?? (y/n)");
            if (Console.ReadLine() == "y"){
                i = 0;
            }
            else{
                Console.WriteLine("To plithos twn pelaton einai:  "+n_customers);
                Console.WriteLine("To sinoliko poso einai:  "+total_poso);
                break;
            }


        }

       
    }
}

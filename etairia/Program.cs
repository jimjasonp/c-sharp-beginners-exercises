using System;
using System.Reflection;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;

class Etairia
{
    static void Main(string[] args)
    {
        double wres, apodoxes, kratiseis ,amoibh, sunolo_am, sunolo_krat, n_ypall,i ;

        sunolo_am = 0;
        n_ypall = 0;
        sunolo_krat = 0;
        i = 0;


        while (i >=0){

            Console.Write("Dwse to onoma sou: ");
            Console.ReadLine();
            


            Console.Write("Poses wres ergasias ? ");
            wres = int.Parse(Console.ReadLine());
            while (wres<0){
                Console.WriteLine("Oi wres de ginetai na einai arnitikes");
                Console.WriteLine("Poses wres ergasias? ");
                wres = int.Parse(Console.ReadLine());
            }


            if(wres<=40){
                apodoxes = wres*25;
            }
            else {
                apodoxes = 40*25 + (wres-40)*10;
            }


            if(apodoxes<=300){
                kratiseis = 0;
            }
            else {
                kratiseis = (apodoxes-300)*0.1;
            }

            amoibh = apodoxes-kratiseis;



            Console.WriteLine("Oi sunolikes apodoxes einai:  "+apodoxes);
            Console.WriteLine("H amoibh einai:  "+amoibh);
            Console.WriteLine("Oi kratiseis einai:  "+kratiseis);

            sunolo_am = amoibh+sunolo_am;

            sunolo_krat = kratiseis+sunolo_krat;
            n_ypall = n_ypall+1;


            Console.WriteLine("Theleis na sunexisw gia ton epomeno ypallhlo?? (y/n)");
            if (Console.ReadLine() == "y"){
                i = 0;
            }
            else{
                Console.WriteLine("To plithos twn ypallhlwn:  "+n_ypall);
                Console.WriteLine("To sinoliko poso amoibwn einai:  "+sunolo_am);
                Console.WriteLine("To sinoliko poso kratisewn einai:  "+sunolo_krat);
                break;
            }


        }

       
    }
}

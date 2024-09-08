using System;
using System.Reflection;
//using System.Diagnostics;
//using System.Runtime.CompilerServices;

class Periballon
{
    static void Main(string[] args)
    {
        double xalkos,arseniko,ydrargyros ,mol,max_mol,min_mol,n_mikrh,n_mesaia,n_megalh,  n_pot,i ;
        string molunsh,name,max_name,min_name;
        
        max_name = "blank";
        min_name = "blank";
        n_pot = 0;
        i = 0;
        max_mol =0;
        min_mol = 0;
        n_mikrh = 0;
        n_mesaia = 0;
        n_megalh = 0;
        
        while (i >=0){

            Console.Write("Dwse to onoma tou potamou: ");
            name = Console.ReadLine();
            
            Console.Write("Poso xalko exei o potamos ? ");
            xalkos = int.Parse(Console.ReadLine());
            while (xalkos<0 || xalkos>10){
                Console.WriteLine("H timh einai apo 0 ews 10");
                Console.WriteLine("Poso xalko exei o potamos ? ");
                xalkos = int.Parse(Console.ReadLine());
            }

            Console.Write("Poso arseniko exei o potamos ? ");
            arseniko = int.Parse(Console.ReadLine());
            while (arseniko<0 || arseniko>10){
                Console.WriteLine("H timh einai apo 0 ews 10");
                Console.WriteLine("Poso arseniko exei o potamos ? ");
                arseniko = int.Parse(Console.ReadLine());
            }

            Console.Write("Poso ydrargyro exei o potamos ? ");
            ydrargyros = int.Parse(Console.ReadLine());
            while (ydrargyros<0 || ydrargyros>10){
                Console.WriteLine("H timh einai apo 0 ews 10");
                Console.WriteLine("Poso ydrargyro exei o potamos ? ");
                ydrargyros = int.Parse(Console.ReadLine());
            }
            if (xalkos<=2 && arseniko<=2 && ydrargyros<=2){
               molunsh = "mikrh"  ;
            }

            else if (xalkos>=6 && arseniko>=6 && ydrargyros>=6){
               molunsh = "megalh"  ;
            }


            else{
                molunsh = "mesaia";
            }
            
            
            mol = ydrargyros+xalkos+arseniko;

            if (mol>=max_mol){
                max_mol = mol;
                max_name = name;
            }

            if (mol<=min_mol){
                min_mol = mol;
                min_name = name;
            }

            if (molunsh == "mikrh"){
                n_mikrh = n_mikrh+1;
            }

            if (molunsh == "mesaia"){
                n_mesaia = n_mesaia+1;
            }
            if (molunsh == "megalh"){
                n_megalh = n_megalh+1;
            }
            Console.WriteLine("H molunsh ston potamo einai:  "+molunsh);
            n_pot = n_pot+1;
            Console.WriteLine("Theleis na sunexisw gia ton epomeno potamo?? (y/n)");
            if (Console.ReadLine() == "y"){
                i = 0;
            }
            else{
                Console.WriteLine("To plithos twn potamwn me mikrh molunsh einai:  "+n_mikrh);
                Console.WriteLine("To plithos twn potamwn me mesaia molunsh einai:  "+n_mesaia);
                Console.WriteLine("To plithos twn potamwn me megalh molunsh einai:  "+n_megalh);
                Console.WriteLine("O potaomos me th megaluterh molunsh einai:  "+ max_name);
                Console.WriteLine("O potamos me th mikroterh molunsh einai:  "+ min_name);
                break;
            }


        }

       
    }
}

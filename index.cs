using System;
namespace curso {
    class Program{
    static void main (string[] args){
        int x = int.Parse(Console.ReadLine());
        string dia;
        if (x==1){
            dia = "Domingo";
        }
        else if (x==2){
            dia = "Segunda-feira";
        }
        else if (x==3){
            dia = "Ter�a-Feira";
        }
        else if (x==4){
            dia = "Quarta-Feira";
        }
        else if (x==5){
            dia = "Quinta-feira";
        }
        else if (x==6){
            dia = "Sexta-Feira";
        }
        else if (x==7){
            dia = "S�bado";
        }
        else{
            dia = "Valor inv�lido!";
        }

        Console.WriteLine("Dia da semana: " + dia);
        Console.ReadLine();
ERRROOOO
        }
    }
}
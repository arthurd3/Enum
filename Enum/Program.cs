using System;

class ENUM {
    enum DiasSemana{Domingo , Segunda , Terça , Quarta , Quinta , Sexta , Sabado};

    static void Main(string[] args)
    {
        int escolher;

        Console.WriteLine("Escolha um Dia Da Semana : 1 a 7");
        escolher = int.Parse(Console.ReadLine());

        while (escolher > 7 || escolher < 1)
        {
            
            Console.Clear();
            Console.WriteLine("Erro Numero Invalido");
            Console.WriteLine("Escolha um Dia Da Semana : 1 a 7");
            escolher = int.Parse(Console.ReadLine());
            Console.Clear();
            
        }


        if (escolher == 1){
            DiasSemana dia0 = (DiasSemana)0;
            Console.WriteLine($"Dia Da Semana escolhido : {dia0}");
        }else{
            DiasSemana dia = (DiasSemana)escolher;
            Console.WriteLine($"Dia Da Semana escolhido : {dia}");
            
        }
    }
}

using System;

namespace Pilhanha{

    class Program{
        static void Main(string[] args){

            Pilha teste = new Pilha();
            Console.WriteLine(teste.estaVazia());

            teste.push(7);
            teste.push(10);
            teste.push(51);

            teste.imprimir();

            teste.pop();
            teste.pop();
            teste.imprimir();



            int valor = 7;
            No noAnterior, noAtual;
            noAnterior = null; 
            noAtual = null;

            Boolean verif = teste.consulta(valor, ref noAtual, ref noAnterior);

            if(verif == true) Console.WriteLine("A busca encontrou!");
            else Console.WriteLine("A busca não encontrou!");

            Console.WriteLine("Você tem: " + teste.retornarQuantidadePilha());
        }
    }
}
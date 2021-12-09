using System;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista Encadeada Simples");
            Lista l1 = new Lista();
            /* l1.InserirNaCabeca(2);
             l1.InserirNaCabeca(7);
             l1.InserirNaCabeca(1);
             l1.InserirNaCabeca(5);
             l1.InserirNaCabeca(11);
             l1.PrintLista();
             Console.WriteLine("Após Remoção");
             l1.RemoveElemento(2);
             l1.RemoveElemento(11);
             l1.PrintLista();
             l1.InserirNaCabeca(24);
             l1.InserirNaCabeca(78);
             Console.WriteLine("Após Inserções");
             l1.PrintLista();
             l1.RemoveElemento(24);
             Console.WriteLine("Após Remoção");
             l1.RemoveElemento(300);
             l1.PrintLista();*/
            l1.InserirOrdemCrescente(76);
            l1.InserirOrdemCrescente(2);
            l1.InserirOrdemCrescente(5);
            l1.InserirOrdemCrescente(542);
            l1.InserirOrdemCrescente(123);
            l1.InserirOrdemCrescente(7);
            l1.InserirOrdemCrescente(72);
            l1.InserirOrdemCrescente(5);
            l1.InserirOrdemCrescente(5);
            l1.InserirOrdemCrescente(678);
            l1.RemoveElemento(72);
            l1.InserirOrdemCrescente(18);
            l1.InserirOrdemCrescente(721);
            l1.InserirOrdemCrescente(38);
            l1.InserirOrdemCrescente(57);
            l1.PrintLista();

        }
    }
}

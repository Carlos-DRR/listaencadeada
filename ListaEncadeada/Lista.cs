using System;

namespace ListaEncadeada
{
    class Lista
    {
        No cabeca;

        public Lista()
        {
            this.cabeca = null;
        }

        public bool Vazia()
        {
            return this.cabeca == null;
        }

        public void InserirNaCabeca(int valor)
        {
            No node = new No();
            node.valor = valor;
            if (Vazia())
            {
                this.cabeca = node;
            }
            else
            {
                node.prox = this.cabeca;
                this.cabeca = node;
            }

        }
        public void InserirOrdemCrescente(int valor)
        {
            No node = new No();
            node.valor = valor;
            if (Vazia())
            {
                this.cabeca = node;
            }
            else
            {
                No atual = this.cabeca;
                No anterior = this.cabeca;

                while (atual != null && atual.valor < valor)
                {
                    anterior = atual;
                    atual = atual.prox;
                }
                if (atual == null)
                {
                    node.prox = null;
                    anterior.prox = node;

                }
                else
                {
                    if(this.cabeca == atual)
                    {
                        this.cabeca = node;
                        node.prox = atual;
                    }
                    else
                    {
                        anterior.prox = node;
                        node.prox = atual;
                    }
                    
                }

            }

        }
        public void RemoveElemento(int valor)
        {
            No anterior = this.cabeca;
            No atual = this.cabeca;

            while (atual != null && atual.valor != valor)
            {
                anterior = atual;
                atual = atual.prox;
            }
            if (atual != null)
            {
                if (this.cabeca == atual)
                {
                    this.cabeca = atual.prox;
                }
                else
                {
                    anterior.prox = atual.prox;
                }

            }
        }
        public void PrintLista() 
        {
            No p = this.cabeca;

            while (p != null)
            {
                Console.WriteLine(p.valor);
                p = p.prox;
            }

        }
    }
}

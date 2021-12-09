using System;
using System.Collections.Generic;
using System.Text;

namespace ListaEncadeada
{
    class No
    {
        private int _valor;
        public int valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        private No _prox;
        public  No prox
        {
            get { return _prox; }
            set { _prox = value; }
        }
        public No()
        {
            this.prox = null;
        }

    }
}

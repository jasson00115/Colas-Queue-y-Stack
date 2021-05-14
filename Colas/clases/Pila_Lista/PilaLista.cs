﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.Pila_Lista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<Object> listaPila;

        public PilaLista()
        {
            cima = -1;
            listaPila = new List<object>();

        }

        public void insertar (Object elemento)
        {
            cima++;
            listaPila.Add(elemento);
        }

        public Object quitar()
        {

            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vacia");
            }
            aux = listaPila[cima];
            listaPila.RemoveAt(cima);
            cima--;
            return aux;

        }

        public Object cimaPila()
        {
            if (!pilaVacia())
            {
                throw new Exception("Pila vacia, no se puede scar elemento");
            }
            return listaPila[cima];
        }

        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }

        public bool pilaVacia()
        {
            return cima == -1;
        }



    }
}

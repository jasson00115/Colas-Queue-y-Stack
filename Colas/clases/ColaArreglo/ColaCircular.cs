﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.ColaArreglo
{
    class ColaCircular
    {

        protected int fin;
        private static int MAXTAMQ = 99;
        protected int frente;

        protected Object[] listaCola;

        //AVANZAR UNA POSICION
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        //VALIDACIONES
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //OPERACION DE MODIFICACION DE COLA
        
        public void insertar (Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;

            }
            else
            {
                throw new Exception("OverFlow de la cola");
            }
        }

        //QUITAR ELEMENTO
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public void borrarcola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;

        }

        //OBTENER EL VALAOR DE FRENTE
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("cola vacia");
            }
        }



    }
}

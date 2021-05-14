using System;
using System.Collections.Generic;
using System.Text;

namespace Colas.clases.ColaArreglo
{
    class ColaLineal
    {

        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        }

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

        //OPERACION PARA TRABAJAR CON DATOS EN LA COLA
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
                
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //QUITAR ELEMENTO DE LA COLA
        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //LIMPIAR TODA LA COLA
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //ACCESO A LA COLA 
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }



    }//end class
}

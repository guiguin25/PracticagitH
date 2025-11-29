using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppListasDobles
{
    class ListaDoble
    {
        public Nodo Cabecera { get; set; }
        public ListaDoble() 
        {
            Cabecera = null;
        }
        public void agregaIni(int dato)
        {
            Nodo nuevo=new Nodo(dato);
            if (Cabecera == null)
            {
                Cabecera = nuevo;
            }
            else
            {
                nuevo.Sigte = Cabecera;
                Cabecera.Ante = nuevo;
                Cabecera = nuevo;
            }

        }
        public void agregaFin(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (Cabecera == null)
            {
                Cabecera = nuevo;
            }
            else
            {
                Nodo aux = Cabecera;
                while (aux.Sigte != null)
                {
                    aux = aux.Sigte;
                }
                aux.Sigte = nuevo;
                nuevo.Ante = aux;
            }
        }
        public void verListaDoble()
        {
            if (Cabecera == null)
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                Nodo aux = Cabecera;
                while (aux != null)
                {
                    Console.Write(aux.Info + "->");
                    aux = aux.Sigte;
                }
                Console.WriteLine();
            }
        }
        public void buscar(int dato)
        {
            if (Cabecera == null)
            {
                Console.WriteLine("Lista vacia");
            }
            else
            {
                Nodo aux = Cabecera;
                while (aux != null)
                {
                    if (aux.Info == dato)
                    {
                        Console.WriteLine("Elemento encontrado: " + aux.Info);
                        return;
                    }
                    aux = aux.Sigte;
                }
                Console.WriteLine("Elemento no encontrado");
            }
        }
        public void eliminarInicio()
        {
            if (Cabecera == null)
            {
                Console.WriteLine("lista vacia");
            }
            else
            {
                Cabecera = Cabecera.Sigte;
                if (Cabecera != null)
                {
                    Cabecera.Ante = null;
                }

            }
        }
        public void eliminarFin()
        {
            if(Cabecera == null)
            {
                Console.WriteLine("lista vacia");
            }
            else
            {
                if (Cabecera.Sigte == null)
                {
                    Cabecera = null;
                }
                else
                {
                    Nodo aux = Cabecera;
                    while (aux.Sigte != null)
                    {
                        aux = aux.Sigte;
                    }
                    aux.Ante.Sigte = null;
                }

            }
        }
        public void elmininarAlMedio(int dato)
        {
            if (Cabecera == null)
            {
                Console.WriteLine("lista vacia");
            }
            else
            {
                Nodo aux = Cabecera;
                while (aux != null)
                {
                    if (aux.Info == dato)
                    {
                        if (aux.Ante != null)
                        {
                            aux.Ante.Sigte = aux.Sigte;
                        }
                        if (aux.Sigte != null)
                        {
                            aux.Sigte.Ante = aux.Ante;
                        }
                        if (aux == Cabecera) // Si el nodo a eliminar es la cabecera
                        {
                            Cabecera = aux.Sigte;
                        }
                        return;
                    }
                    aux = aux.Sigte;
                }
                Console.WriteLine("Elemento no encontrado");
            }
        }
    }

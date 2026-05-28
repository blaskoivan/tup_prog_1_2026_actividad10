using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Services
{
    internal class NumericService
    {
        private int[] valores = new int[100];
        private int contador;

        public NumericService()
        {
            contador = 0;
        }

        public void Registrar(int valor)
        {
            valores[contador] = valor;
            contador++;
        }

        public int VerContador(int contador)
        {
            return contador;
        }

        public int VerValor(int idx)
        {
            return valores[idx];
        }

        public int Buscar(int valor)
        {
            for (int i = 0; i < contador; i++)
            {
                if (valores[i] == valor)
                {
                    return i;
                }
                return -1;
            }
        }

        public double CalcularPromedio(int contador)
        {
            double suma = 0;
            double promedio = 0;
            for (int i = 0; i < contador; i++)
            {
                suma += valores[i];

            }
            return promedio = suma / contador;
        }

    }
}

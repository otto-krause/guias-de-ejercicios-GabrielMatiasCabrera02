using System;

namespace E1
{
    public class Gatito
    {
        string nombre;
        bool vacuna;
        int energia;
        public Gatito(string nombre, bool vacuna, int energia)
        {
            this nombre = nombre;
            this vacuna = vacuna;
            this energia = energia;
        }
        public bool EstaVacunado(bool vacuna)
        {
            return !vacunas;
        }
        public int Jugar(int energia,int minutos)
        {
            (enegia-2)*minutos;
        }
        public int Comer(int energia)
        {
            energia+50;
        }
        public bool EstaSaludable(int energia,bool vacunado)
        {
            if(vacuna == true && energia>30)
            {
                return true;
            }
            return false;
        }
    }
}
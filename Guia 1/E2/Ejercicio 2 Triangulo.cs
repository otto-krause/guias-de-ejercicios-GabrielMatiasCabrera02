namespace E2
{
    public class Ejercicio 2 Triangulo
    {
        public class triangulo
        {
            float lado1;
            float lado2;
            float lado3;
            public bool EsEscaleno(float lado1, float lado2, float lado3)
            {
                if(lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                {
                    return true;
                }
                return false;
            }
            public bool EsIsosceles(float lado1, float lado2, float lado3)
            {
                if(lado1 == lado2 && lado1 != lado3 && lado3 != lado2 || lado2 == lado3 && lado2 != lado1 && lado1!= lado3 || lado1 == lado3 && lado1 != lado2 && lado3 != lado2)
                {
                    return true;
                }
                return false;
            }
            public bool EsEquilatero(float lado1, float lado2, float lado3)
            {
                if(lado1 == lado2 && lado2 == lado3)
                {
                    return true;
                }
                return true;
            }
            public bool EsTrianguloRectangulo(float lado1, float lado2, float lado3)
            {
                if((lado1*lado1 + lado2*lado2) == lado3*lado3 || (lado2*lado2 + lado3*lado3) == lado1*lado1 || (lado1*lado1 + lado3*lado3) == lado2*lado2)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;

namespace DevelopmentChallenge.Data.FormasGeometricas.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public override TipoFormaEnum Tipo => TipoFormaEnum.Rectangulo;

        public override decimal Lado { get; }

        private decimal OtroLado { get; }

        public Rectangulo(decimal lado, decimal otroLado)
        {
            Lado = lado;
            OtroLado = otroLado;
        }

        //Fuente cálculo = https://www.calculat.org/es/area-perimetro/rectangulo/
        public override decimal CalcularArea() => Lado * OtroLado;

        public override decimal CalcularPerimetro() => 2 * (Lado + OtroLado);
    }
}

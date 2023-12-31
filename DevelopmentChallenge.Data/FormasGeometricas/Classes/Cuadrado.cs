using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;
using DevelopmentChallenge.Data.Helpers;

namespace DevelopmentChallenge.Data.FormasGeometricas.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public override TipoFormaEnum Tipo => TipoFormaEnum.Cuadrado;
        public override decimal Lado { get; }

        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularArea() => Lado * Lado;

        public override decimal CalcularPerimetro() => Lado * 4;
    }
}

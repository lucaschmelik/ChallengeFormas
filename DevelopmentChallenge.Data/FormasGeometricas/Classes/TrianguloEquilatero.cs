using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;
using System;

namespace DevelopmentChallenge.Data.FormasGeometricas.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public override TipoFormaEnum Tipo => TipoFormaEnum.TrianguloEquilatero;
        public override decimal Lado { get; }

        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;

        public override decimal CalcularPerimetro() => Lado * 3;
    }
}

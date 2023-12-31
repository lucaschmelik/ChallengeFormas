using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;
using System;

namespace DevelopmentChallenge.Data.FormasGeometricas.Classes
{
    public class Circulo : FormaGeometrica
    {
        public override TipoFormaEnum Tipo => TipoFormaEnum.Circulo;
        public override decimal Lado { get; }

        public Circulo(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularArea() => (decimal)Math.PI * (Lado / 2) * (Lado / 2);

        public override decimal CalcularPerimetro() => (decimal)Math.PI * Lado;
    }
}

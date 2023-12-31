using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;

namespace DevelopmentChallenge.Data.FormasGeometricas.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public override TipoFormaEnum Tipo => TipoFormaEnum.Trapecio;

        private decimal BaseMayor { get; }
        private decimal BaseMenor { get; }
        private decimal Altura { get; }
        private decimal LadoIzquierdo { get; }
        private decimal LadoDerecho { get; }
        public override decimal Lado => throw new System.NotImplementedException();

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            LadoIzquierdo = ladoIzquierdo;
            LadoDerecho = ladoDerecho;
        }

        //Fuente cálculo = https://www.calculat.org/es/area-perimetro/trapecio/
        public override decimal CalcularArea() => ((BaseMayor + BaseMenor) * Altura) / 2;
        
        public override decimal CalcularPerimetro() => BaseMayor + BaseMenor + LadoIzquierdo + LadoDerecho;
    }
}

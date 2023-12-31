using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.FormasGeometricas.Abstracts
{
    public abstract class FormaGeometrica
    {
        public abstract TipoFormaEnum Tipo { get; }
        public abstract decimal Lado { get; }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}

using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Helpers
{
    public static class IdiomaHelper
    {
        public static string TraducirEncabezado(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "<h1>Reporte de Formas</h1>";
                case Idioma.Ingles:
                    return "<h1>Shapes report</h1>";
                case Idioma.Italiano:
                    return "<h1>Rapporto delle forme</h1>";
                default:
                    return string.Empty;
            }
        }

        public static string TraducirListaVacia(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "<h1>Lista vacía de formas!</h1>";
                case Idioma.Ingles:
                    return "<h1>Empty list of shapes!</h1>";
                case Idioma.Italiano:
                    return "<h1>Lista vuota di forme!</h1>";
                default:
                    return string.Empty;
            }
        }

        public static string TraducirPalabraForma(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "formas";
                case Idioma.Ingles:
                    return "shapes";
                case Idioma.Italiano:
                    return "forme";
                default:
                    return string.Empty;
            }
        }

        public static string TraducirPalabraPerimetro(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return "Perimetro";
                case Idioma.Ingles:
                    return "Perimeter";
                case Idioma.Italiano:
                    return "Perimetro";
                default:
                    return string.Empty;
            }
        }

        public static string TraducirTipoForma(Idioma idioma, TipoFormaEnum tipoForma, bool esPlural)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    switch (tipoForma)
                    {
                        case TipoFormaEnum.Cuadrado:
                            return esPlural? "Cuadrados" : "Cuadrado" ;
                        case TipoFormaEnum.TrianguloEquilatero:
                            return esPlural ? "Triángulos" : "Triángulo" ;
                        case TipoFormaEnum.Circulo:
                            return esPlural ? "Círculos" : "Círculo";
                        case TipoFormaEnum.Trapecio:
                            return esPlural ? "Trapecios" : "Trapecio";
                        case TipoFormaEnum.Rectangulo:
                            return esPlural ? "Rectangulos" : "Rectangulo";
                        default:
                            return string.Empty;
                    }

                case Idioma.Ingles:
                    switch (tipoForma)
                    {
                        case TipoFormaEnum.Cuadrado:
                            return esPlural ? "Squares" : "Square";
                        case TipoFormaEnum.TrianguloEquilatero:
                            return esPlural ? "Triangles" : "Triangle";
                        case TipoFormaEnum.Circulo:
                            return esPlural ? "Circles" : "Circle";
                        case TipoFormaEnum.Trapecio:
                            return esPlural ? "Trapezoids" : "Trapezoid";
                        case TipoFormaEnum.Rectangulo:
                            return esPlural ? "Rectangles" : "Rectangle";
                        default:
                            return string.Empty;
                    }

                case Idioma.Italiano:
                    switch (tipoForma)
                    {
                        case TipoFormaEnum.Cuadrado:
                            return esPlural ? "Quadrati" : "Quadrato";
                        case TipoFormaEnum.TrianguloEquilatero:
                            return esPlural ? "Triangoli" : "Triangolo";
                        case TipoFormaEnum.Circulo:
                            return esPlural ? "Cerchi" : "Cerchio";
                        case TipoFormaEnum.Trapecio:
                            return esPlural ? "Trapezi" : "Trapezio";
                        case TipoFormaEnum.Rectangulo:
                            return esPlural ? "Rettangoli" : "Rettangolo";
                        default:
                            return string.Empty;
                    }

                default:
                    return string.Empty;
            }
        }
    }
}

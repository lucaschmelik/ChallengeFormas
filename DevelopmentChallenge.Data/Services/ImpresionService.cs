using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;
using DevelopmentChallenge.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Services
{
    public class ImpresionService
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(IdiomaHelper.TraducirListaVacia(idioma));
            }
            else
            {
                sb.Append(IdiomaHelper.TraducirEncabezado(idioma));

                if (formas.Count == 1)
                {
                    var forma = formas.First();
                    sb.Append(ObtenerLinea(idioma, forma.Tipo, 1, forma.CalcularArea(), forma.CalcularPerimetro()));
                    sb.Append(GenerarTotales(formas, idioma));
                }
                else
                {
                    var formasAgrupadas = formas.GroupBy(x => x.Tipo);

                    foreach (var grupo in formasAgrupadas)
                    {
                        var tipoForma = grupo.Key;
                        var totalPerimetro = 0m;
                        var totalArea = 0m;
                        var formasDelTipo = grupo.ToList();

                        foreach (var forma in formasDelTipo)
                        {
                            totalPerimetro += forma.CalcularPerimetro();
                            totalArea += forma.CalcularArea();
                        }

                        sb.Append(ObtenerLinea(idioma, tipoForma, formasDelTipo.Count, totalArea, totalPerimetro));

                    }
                    sb.Append(GenerarTotales(formas, idioma));
                }
            }

            return sb.ToString();
        }

        private static string GenerarTotales(List<FormaGeometrica> formas, Idioma idioma)
        {
            var totalFormas = formas.Count;
            var totalPerimetro = Math.Round(formas.Sum(forma => forma.CalcularPerimetro()), 2);
            var totalArea = Math.Round(formas.Sum(forma => forma.CalcularArea()), 2);

            return $"TOTAL:<br/>{totalFormas} {IdiomaHelper.TraducirPalabraForma(idioma)} {IdiomaHelper.TraducirPalabraPerimetro(idioma)} {totalPerimetro.ToString($"G", CultureInfo.GetCultureInfo("es-ES"))} Area {totalArea.ToString($"G", CultureInfo.GetCultureInfo("es-ES"))}";
        }

        private static string ObtenerLinea(Idioma idioma, TipoFormaEnum tipoForma, int cantidad, decimal area, decimal perimetro)
        {
            return $"{cantidad} {IdiomaHelper.TraducirTipoForma(idioma, tipoForma, cantidad > 1)} | Area {Math.Round(area, 2).ToString($"G", CultureInfo.GetCultureInfo("es-ES"))} | {IdiomaHelper.TraducirPalabraPerimetro(idioma)} {Math.Round(perimetro, 2).ToString($"G", CultureInfo.GetCultureInfo("es-ES"))} <br/>";
        }
    }
}

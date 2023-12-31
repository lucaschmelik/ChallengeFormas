/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * ! Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * ! Implementar la forma Trapecio/Rectangulo. 
 * ! Agregar el idioma Italiano (o el deseado) al reporte.
 * ! Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * ! Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using NUnit.Framework.Legacy;
using NUnit.Framework;
using System.Collections.Generic;
using DevelopmentChallenge.Data.FormasGeometricas.Abstracts;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.FormasGeometricas.Classes;
using DevelopmentChallenge.Data.Services;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestsRefactorizado
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            ClassicAssert.AreEqual("<h1>Lista vacía de formas!</h1>", ImpresionService.Imprimir(new List<FormaGeometrica>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            ClassicAssert.AreEqual("<h1>Empty list of shapes!</h1>",
                ImpresionService.Imprimir(new List<FormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            ClassicAssert.AreEqual("<h1>Lista vuota di forme!</h1>",
                ImpresionService.Imprimir(new List<FormaGeometrica>(), Idioma.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Castellano);

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Italiano);

            ClassicAssert.AreEqual("<h1>Rapporto delle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forme Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Ingles);

            ClassicAssert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnItaliano()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Italiano);

            ClassicAssert.AreEqual("<h1>Rapporto delle forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 forme Perimetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ImpresionService.Imprimir(formas, Idioma.Ingles);

            ClassicAssert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = ImpresionService.Imprimir(formas, Idioma.Castellano);

            ClassicAssert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapecio()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(8, 5, 4, 3, 3)
            };

            var resumen = ImpresionService.Imprimir(formas, Idioma.Ingles);

            ClassicAssert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapezoid | Area 26 | Perimeter 19 <br/>TOTAL:<br/>8 shapes Perimeter 116,66 Area 117,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var cuadrados = new List<FormaGeometrica> { new Trapecio(10, 6, 7, 4, 4) };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Castellano);

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 56 | Perimetro 24 <br/>TOTAL:<br/>1 formas Perimetro 24 Area 56", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTrapeciosEnIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Trapecio(10, 6, 7, 4, 4),
                new Trapecio(8, 5, 4, 3, 3)
            };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Ingles);

            ClassicAssert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 82 | Perimeter 43 <br/>TOTAL:<br/>2 shapes Perimeter 43 Area 82", resumen);
        }

        [TestCase]
        public void TestResumenListaConRectangulo()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(8, 5, 4, 3, 3),
                new Rectangulo(4, 6)
            };

            var resumen = ImpresionService.Imprimir(formas, Idioma.Ingles);

            ClassicAssert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Trapezoid | Area 26 | Perimeter 19 <br/>1 Rectangle | Area 24 | Perimeter 20 <br/>TOTAL:<br/>9 shapes Perimeter 136,66 Area 141,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(2, 5) };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Castellano);

            ClassicAssert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 10 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 10", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasRectangulosEnIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Rectangulo(4, 6),
                new Rectangulo(2, 5)
            };

            var resumen = ImpresionService.Imprimir(cuadrados, Idioma.Ingles);

            ClassicAssert.AreEqual("<h1>Shapes report</h1>2 Rectangles | Area 34 | Perimeter 34 <br/>TOTAL:<br/>2 shapes Perimeter 34 Area 34", resumen);
        }

        [TestCase]
        public void TestResumenListaConRectanguloEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Trapecio(8, 5, 4, 3, 3),
                new Rectangulo(4, 6)
            };

            var resumen = ImpresionService.Imprimir(formas, Idioma.Italiano);

            ClassicAssert.AreEqual(
                "<h1>Rapporto delle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>1 Trapezio | Area 26 | Perimetro 19 <br/>1 Rettangolo | Area 24 | Perimetro 20 <br/>TOTAL:<br/>9 forme Perimetro 136,66 Area 141,65",
                resumen);
        }
    }
}

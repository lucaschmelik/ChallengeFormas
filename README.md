# ChallengeFormas

## Desafío

Tenemos un método que genera un reporte en base a una colección de formas geométricas, procesando algunos datos para presentar como reporte información extra. La firma del método es: public static string Imprimir(List<FormaGeometrica> formas, int idioma) y se encuentra ubicado en la clase FormaGeometrica.cs

En consecuencia a como fue codificado este módulo, al equipo de desarrollo se le hace muy difícil el poder agregar una nueva forma geométrica o implementar la impresión del reporte en otro idioma. Nos gustaría poder dar soporte para que en el futuro los desarrolladores puedan agregar otros tipos de formas y obtener el reporte en otros idiomas con más agilidad. ¿Nos podrías ayudar a refactorizar la clase FormaGeometrica?

Acompañando al proyecto encontrarás una serie de tests unitarios (librería NUnit) que describen el comportamiento actual del método Imprimir. Se puede modificar absolutamente cualquier cosa del código y de los tests, con la única condición que los tests deben pasar correctamente al entregar la solución.
Dentro del código hay un TODO con los requerimientos técnicos y del usuario a satisfacer.

## Tecnología

La solución fue creada con Visual Studio 2019, consta de dos proyectos en C# sobre .NET Framework 4.6.2, uno específico para Tests y otro que contiene el negocio a mejorar, el siguiente ZIP que le ofrecemos contiene lo mencionado antes y los packages de nuget:
 DevelopmentChallenge (1).zip


## Manejo de Errores con Paquetes

En caso de encontrar errores relacionados con los paquetes, sigue estos pasos para solucionarlos:

1. **Eliminación de Referencias no Encontradas:**
   - Si encuentras referencias que no se encuentran en tu máquina, elimínalas del proyecto.
   - Abre el proyecto en Visual Studio y ve a la sección de referencias.
   - Elimina las referencias marcadas como no encontradas.

2. **Migración de Paquetes:**
   - Si enfrentas problemas con los paquetes, realiza la migración desde el paquete correspondiente.
   - Haz clic derecho en `References` de `DevelopmentChallenge.Data.Tests` y selecciona `Migrate package.config to packageReferences` para actualizar todos los paquetes a la versión especificada en el proyecto.

3. **Restauración de Paquetes:**
   - Realiza la compilación (build) nuevamente del proyecto.
   - Ejecuta nuevamente las pruebas para asegurarte de que los paquetes se han restaurado correctamente.

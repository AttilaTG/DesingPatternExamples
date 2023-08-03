# Paso a paso para crear el patron Builder en C#

El patrón de diseño Builder se utiliza para construir objetos complejos paso a paso, permitiendo crear diferentes representaciones del mismo objeto. 
El Director es responsable de coordinar el proceso de construcción utilizando un Builder para cada paso. 

1. Interfac: Crea una interfaz para el objeto que quieres construir (IAbstractBuilder). Esta interfaz debe tener todos los métodos que el objeto debe tener y un metodo reset.
2. Builders concretos: Crea uno o varios Builders específicos de los productos que se vayan a crear (HouseBuilder, HouseHandbookBuilder) e implementa la interfaz.
3. Objetos complejos: Crea los objetos complejos que desees construir.(House, HouseInformationHandbook) 
Esta clase debe tener múltiples atributos para almacenar las partes individuales del objeto final.
4. Director: Crea un objeto Director que será el encargado de construir los objetos a través de metodos, que reciben como parametro la interfaz builder.
5. Cliente : Crea un cliente que asociará los objetos builder con la clase Driector.

## Si estás dudando en implementar Builder, puedes hacerte las siguientes preguntas:

- ¿Mi objeto tiene muchas partes?
- ¿Necesito crear diferentes versiones de mi objeto?

Si tu respuesta es si a cualquiera de ellas, es posible que puedas implementar el patron Builder en tu solución
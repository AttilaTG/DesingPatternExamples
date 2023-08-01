# Cómo crear e implementar el patrón Abstract Factory en C#

1. Crea una interfaz o clase abstracta para el producto **(IHeadphones, ITV, IWashingMachine)**. Esta interfaz o clase abstracta debe definir los métodos que todos los productos deben implementar.
2. Crea una clase concreta para cada tipo de producto que quieras crear **(LGTV, LGHeadphones, LGWashingMachine, etc.)**. Estas clases deben implementar la interfaz o clase abstracta del producto.
3. Crea una clase de fábrica abstracta **(IAbstractFactory)**. La clase de fábrica abstracta debe tener un método que cree un nuevo objeto de producto. El método de la fábrica debe recibir un parámetro que indique el tipo de producto que se quiere crear.
4. Crea una clase de fábrica concreta para cada tipo de fábrica que quieras crear **(LGFactory, etc...)**. Estas clases deben extender la clase de fábrica abstracta y proporcionar implementaciones para el método de la fábrica que cree objetos de productos específicos.
5. En el código que utiliza los productos **(Program.cs)**, llama al método de la fábrica para crear un nuevo objeto de producto. 

## Preguntas adicionales que puedes hacerte si estás tratando de decidir si usar o no una Abstract Factory:

- ¿Hay una familia de objetos que están relacionados y que a menudo se usan juntos?
- ¿Los objetos de la familia deben crearse en función de los mismos criterios?
- ¿Los objetos de la familia deben ser intercambiables?
- ¿Los objetos de la familia deben ser extensibles?
- ¿Los objetos de la familia deben ser reemplazables?
- Si responde "sí" a cualquiera de estas preguntas, entonces el patrón de diseño Abstract Factory puede ser una buena opción para usted.

El patrón de diseño Abstract Factory es una forma de crear objetos sin tener que especificar el tipo de objeto que se creará. Esto puede ser útil cuando hay una familia de objetos que están relacionados y que a menudo se usan juntos. 
Por ejemplo, si estás creando un juego de cartas, puedes usar una Abstract Factory para crear diferentes tipos de cartas, como corazones, diamantes, tréboles y picas.

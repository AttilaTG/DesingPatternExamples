**Pasos para crear una Factory**

1. Crea una interfaz Product **(ICellPhone)** --> Debe contener los métodos que todos los productos deben tener.
2. Crea una clase concreta para cada tipo de Product **(Android, IOS)** --> Deben implementar la interfaz.
3. Crea la clase Factory **(CellPhoneFactory)** --> Debe tener un método que crea el nuevo producto.
4. En el código que utiliza los productos, llamamos a la fábrica para crear el producto.

Aquí hay algunas preguntas que debes hacerte si no estás seguro de si usar o no el patrón de diseño Factory:

- ¿Hay diferentes tipos de objetos que deben crearse?
- ¿Los objetos deben crearse en función de la entrada del usuario?
- ¿Los objetos deben crearse en función de las condiciones del sistema?
- ¿Los objetos deben crearse en función de los datos que están disponibles?
- ¿Los objetos deben crearse en función de la configuración del sistema?

Si respondes "sí" a alguna de estas preguntas, entonces el patrón de diseño Factory puede ser una buena opción para ti.

El patrón de diseño Factory es una forma de crear objetos sin tener que especificar el tipo de objeto que se creará. Esto puede ser útil cuando hay diferentes tipos de objetos que deben crearse, o cuando los objetos deben crearse según la entrada del usuario, las condiciones del sistema, los datos que están disponibles o la configuración del sistema.

El patrón de diseño Factory puede ayudar a hacer que tu código sea más flexible y extensible. También puede ayudar a hacer que tu código sea más fácil de mantener y depurar.

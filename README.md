# 🧩 Proyecto: MetodologíasFix

Este proyecto implementa los distintos patrones de diseño vistos en la materia **Metodología de la Programación**, siguiendo la estructura modular de clases y ejercicios solicitados en las prácticas 3, 4 y 5.

---

## ✅ Correcciones y mejoras recientes

- **Patrón Observer:**  
  Se corrigió la implementación según la indicación del profesor.  
  Ahora el método `Actualizar()` recibe un **estado** en lugar de un string de acción, de acuerdo a la teoría del patrón Observer.  
  Además, se incorporó la interfaz **`IObservado`**, la cual fue implementada en la clase **`Profesor`** para permitir la suscripción y notificación de los observadores.

- **Lógica de Órdenes:**  
  Se movió la lógica de ejecución de órdenes (`OrdenInicio`, `OrdenLlegaAlumno`, `OrdenAulaLlena`) fuera de las colecciones (`Cola` y `Pila`).  
  Ahora dicha lógica se maneja **en el `Main`**, utilizando un **iterador (`IteradorCola`)** para recorrer la colección y ejecutar las órdenes según corresponda.

- **Uso del Iterador:**  
  Se aplicó correctamente el patrón *Iterator* mediante el uso de la interfaz `IIterador` y su implementación `IteradorCola`.  
  El `Main` utiliza el iterador devuelto por `cola.crearIterador()` para recorrer los elementos sin depender de la estructura interna de la colección.

---

## 📂 Estructura de Carpetas y Clases

### 🧱 Adapter
- **AlumnoAdapter.cs:** adapta los objetos `IAlumno` a la interfaz utilizada por `TeacherMDPI`, permitiendo que interactúen sin modificar el código base del teacher.

---

### 🏫 ClasesAula
- **Aula.cs:** coordina la relación entre `TeacherMDPI` y los alumnos; gestiona el inicio de clase, la llegada de alumnos y el cierre de la lección.  
- **OrdenInicio.cs / OrdenLlegaAlumno.cs / OrdenAulaLlena.cs:** implementan las órdenes que controlan las distintas fases del aula.  
- **IOrdenEnAula1.cs / IOrdenEnAula2.cs / IOrdenable.cs:** interfaces que definen el comportamiento de las órdenes.

---

### 📦 Colecciones
- **Cola.cs / Pila.cs:** estructuras de datos que almacenan elementos `MiComparable`.  
  Ya **no contienen la lógica de ejecución de órdenes**, que fue movida al `Main`.  
- **Conjunto.cs / ColeccionMultiple.cs:** implementaciones adicionales de colecciones.  
- **IColeccionable.cs:** interfaz base de todas las colecciones.

---

### 🎨 Decorator
Implementación del patrón *Decorator* aplicado a los alumnos:
- **DecoradorConLegajo.cs**
- **DecoradorConOrden.cs**
- **DecoradorConRecuadro.cs**
- **DecoradorNotaEnLetras.cs**
- **DecoradorPromocion.cs**
  
Permiten añadir comportamientos visuales o lógicos (legajo, recuadro, nota, promoción, etc.) de forma dinámica a los objetos `IAlumno`.

---

### ⚖ Estrategias
- **CompararAlumnoCalificacion.cs / CompararAlumnoDni.cs / CompararAlumnoNombre.cs / CompararAlumnoLegajo.cs / CompararAlumnoPromedio.cs:**  
  implementan distintas estrategias de comparación para alumnos.
- **IEstrategiaComparacion.cs:** interfaz base de todas las estrategias.

---

### 🏭 Fabricas
Implementación del patrón *Factory Method*:
- **FabricaDeComparables.cs:** clase abstracta con métodos estáticos `crearAleatorio()` y `crearPorTeclado()`.
- **FabricaDeAlumnosNormales.cs / FabricaDeAlumnosMuyEstudiosos.cs / FabricaDeNumeros.cs / FabricaDeProfesores.cs / StudentsFactory.cs:**  
  fábricas concretas para distintos tipos de objetos.
- **LectorDeDatos.cs:** permite la carga manual de datos desde consola.

---

### 🔁 Iteradores
- **IIterador.cs / IIterable.cs:** interfaces que definen el comportamiento de los iteradores y las colecciones iterables.
- **IteradorCola.cs / IteradorPila.cs / IteradorConjunto.cs:** implementaciones concretas para cada tipo de colección.  
  Actualmente se utiliza **IteradorCola** en el `Main` para recorrer los alumnos y ejecutar las órdenes.

---

### 🧑‍🏫 MDPI
- **TeacherMDPI.cs:** clase provista por la cátedra, representa al profesor (no modificable).
- **CodigoCatedra.cs:** define estructuras o dependencias base provistas por la cátedra.

---

### 👩‍🎓 Objetos
- **Alumno.cs / AlumnoNormal.cs / AlumnoMuyEstudioso.cs:** jerarquía principal de alumnos con comportamiento y comparación personalizados.
- **Numero.cs / Persona.cs / Profesor.cs:** otras entidades del modelo.
- **IComparable.cs:** interfaz base que define `SosIgual`, `SosMenor` y `SosMayor`.

---

### 👀 Observer
- **IObservador.cs:** define el método `Actualizar(Estado estado)`.  
- **IObservado.cs:** nueva interfaz creada; define los métodos `AgregarObservador()`, `QuitarObservador()` y `Notificar()`.  
- **Profesor.cs:** implementa `IObservado`, notificando a los alumnos observadores de los cambios de estado.

---

### 🧩 Proxy
- **ProxyAlumno.cs:** implementa el patrón *Proxy*.  
  Crea instancias reales de `AlumnoNormal` o `AlumnoMuyEstudioso` **solo cuando el Teacher toma el examen**, según el flag del proxy.

---

### 🛠 Otros
- **Funciones.cs:** contiene los métodos `llenar()` e `informar()`, usados para poblar y mostrar información de las colecciones.  
- **GeneradorDeDatos.cs:** genera nombres, enteros y estrategias aleatorias para las pruebas.

---

### 💻 Program.cs
Punto de entrada del programa.  
Coordina la ejecución del aula, el llenado de la colección y las órdenes.  
Utiliza el `IteradorCola` para recorrer los alumnos y ejecutar las fases:
1. Inicio de la clase.  
2. Llegada de alumnos.  
3. Clase llena y evaluación.

---

## 📘 Notas finales
- Proyecto adaptado a **.NET 8.0 (C#)**.  
- Cumple los patrones **Factory**, **Strategy**, **Decorator**, **Adapter**, **Proxy**, **Iterator**, **Command** y **Observer**.  
- Estructura modular organizada por carpetas temáticas.  
- Código ampliamente comentado con referencias a cada ejercicio de las prácticas.

---

Autor: **Máximo Fara**  
Universidad Nacional Arturo Jauretche  
Carrera: Ingeniería Informática  
Materia: *Metodología de la Programación 1*

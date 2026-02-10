# 📚 LISTA ENLAZADA SIMPLE

Proyecto educativo para aprender estructura de datos: Lista Enlazada Simple

---

## 🎯 ¿Qué es una Lista Enlazada?

Una **lista enlazada** es una estructura de datos donde cada elemento (llamado **nodo**) contiene:
1. Un **dato** (el valor que guardamos)
2. Una **referencia** al siguiente nodo

**Ejemplo visual:**
```
[5] -> [3] -> [8] -> [1] -> null

Cada [] es un nodo
Las flechas (->) son las referencias
null significa "fin de la lista"
```

---

## 🏗️ Estructura del Proyecto

```
MiProyecto/
├── Program.cs              # Programa principal con el menu
├── Models/
│   ├── Nodo.cs            # Clase que representa cada elemento
│   └── ListaEnlazada.cs   # Clase con todas las operaciones
└── MiProyecto.csproj      # Configuracion del proyecto
```

---

## 📖 Conceptos Importantes

### 1. Nodo
Es cada elemento de la lista. Tiene dos partes:
- **Dato**: El valor que guardamos (en este caso, un número entero)
- **Siguiente**: Apunta al próximo nodo (o null si es el último)

```csharp
public class Nodo
{
    public int Dato { get; set; }      // El valor
    public Nodo? Siguiente { get; set; } // Referencia al siguiente
}
```

### 2. Cabeza (Head)
Es el primer nodo de la lista. Si cabeza = null, la lista está vacía.

### 3. Recorrido
Para visitar todos los elementos, empezamos en la cabeza y seguimos las referencias:
```csharp
Nodo actual = cabeza;
while (actual != null)
{
    // Hacer algo con actual.Dato
    actual = actual.Siguiente; // Avanzar al siguiente
}
```

---

## ⚙️ Operaciones Implementadas

### 1. Insertar Elemento
Agrega un número al **final** de la lista.

**Pasos:**
1. Crear un nuevo nodo con el valor
2. Si la lista está vacía, el nuevo nodo es la cabeza
3. Si no, buscar el último nodo
4. Conectar el último nodo con el nuevo

**Complejidad:** O(n) - tiene que recorrer toda la lista

---

### 2. Borrar por Posición
Elimina un elemento según su índice (posición 0 = primero).

**Pasos:**
1. Si es posición 0, mover la cabeza al siguiente
2. Si no, buscar el nodo ANTERIOR al que vamos a borrar
3. Hacer que el anterior "salte" el nodo a borrar

**Ejemplo:**
```
Lista: [5] -> [3] -> [8]
Borrar posición 1 (el 3):
       [5] -----> [8]  (saltamos el 3)
```

**Complejidad:** O(n)

---

### 3. Borrar por Contenido
Busca un valor específico y lo elimina.

**Pasos:**
1. Si la cabeza tiene el valor, moverla al siguiente
2. Si no, recorrer la lista buscando el valor
3. Cuando lo encontramos, hacer el "salto"

**Complejidad:** O(n)

---

### 4. Imprimir Lista
Muestra todos los elementos con su posición.

**Pasos:**
1. Empezar en la cabeza
2. Mientras no sea null:
   - Imprimir el dato
   - Avanzar al siguiente

**Complejidad:** O(n)

---

### 5. Ordenar Lista (Bubble Sort)
Ordena los elementos de menor a mayor.

**Algoritmo Bubble Sort:**
- Comparar cada elemento con el siguiente
- Si están en orden incorrecto, intercambiarlos
- Repetir hasta que no haya más intercambios

**Ejemplo:**
```
[5] [3] [8] [1]
 ↓   ↓          Comparar 5 y 3, intercambiar
[3] [5] [8] [1]
     ↓   ↓      Comparar 5 y 8, OK
[3] [5] [8] [1]
         ↓   ↓  Comparar 8 y 1, intercambiar
[3] [5] [1] [8]
... repetir hasta ordenar ...
[1] [3] [5] [8]
```

**Complejidad:** O(n²) - no es el más rápido pero es fácil de entender

---

## 🚀 Cómo Usar el Programa

### Compilar:
```bash
cd MiProyecto
dotnet build
```

### Ejecutar:
```bash
dotnet run
```

### Ejemplo de Uso:
```
LISTA ENLAZADA SIMPLE
---------------------

1. Insertar Elemento
2. Borrar Elemento por Posicion
3. Borrar Elemento por Contenido
4. Imprimir Lista
5. Ordenar Lista
6. Salir

Opcion: 1
Numero a insertar: 5
Elemento 5 insertado

Opcion: 1
Numero a insertar: 3
Elemento 3 insertado

Opcion: 4

Contenido de la lista:
Posicion 0: 5
Posicion 1: 3
Total: 2 elementos

Opcion: 5
Lista ordenada

Opcion: 4

Contenido de la lista:
Posicion 0: 3
Posicion 1: 5
Total: 2 elementos
```

---

## 📊 Ventajas y Desventajas

### ✅ Ventajas:
- **Tamaño dinámico**: Crece y decrece según necesidad
- **Inserción/eliminación eficiente** al inicio (O(1))
- No necesita memoria continua

### ❌ Desventajas:
- **Acceso lento por posición** (O(n)) - hay que recorrer
- Usa más memoria (por las referencias)
- No se puede acceder aleatoriamente como un array

---

## 🎓 Conceptos de C# Usados

### Propiedades (Properties)
```csharp
public int Dato { get; set; }
```
- `get`: obtener el valor
- `set`: establecer el valor

### Nullable Types
```csharp
Nodo? siguiente  // El ? significa que puede ser null
```

### Constructor
```csharp
public Nodo(int dato)  // Se ejecuta al crear el objeto
```

### Métodos static
```csharp
static void Main()  // Se puede llamar sin crear objeto
```

### Ciclo while
```csharp
while (condicion)   // Repite mientras la condicion sea true
```

### Switch
```csharp
switch (opcion)     // Evalúa diferentes casos
{
    case "1": ...
    case "2": ...
}
```

---

## 💡 Tips para Estudiar

1. **Dibuja la lista** en papel mientras pruebas el programa
2. **Agrega Console.WriteLine** para ver qué pasa en cada paso
3. **Modifica el código** y prueba qué sucede
4. **Compara** con arrays: ¿cuándo usar cuál?

---

## 📝 Ejercicios Adicionales

Para practicar más, intenta agregar:

1. **InsertarAlInicio()** - Insertar al principio (más rápido)
2. **ContarElementos()** - Contar cuántos nodos hay
3. **BuscarElemento()** - Verificar si existe un valor
4. **Vaciar()** - Eliminar todos los elementos
5. **InsertarEnPosicion()** - Insertar en una posición específica

---

## 🎯 Fecha de Entrega

**12 de febrero de 2026**

---

## ✨ ¡Éxito en tu aprendizaje!

Recuerda: la programación se aprende practicando. 
¡No tengas miedo de experimentar y cometer errores!

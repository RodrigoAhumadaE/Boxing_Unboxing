// Crear una lista vacía de tipo objeto
using System.ComponentModel;

List<object> objetos = new List<object>();

// Agregue los siguientes valores a la lista: 7, 28, -1, true, "chair"
objetos.Add(7);
objetos.Add(28);
objetos.Add(-1);
objetos.Add(true);
objetos.Add("chair");

// Recorra la lista e imprima todos los valores.
foreach(object valor in objetos){
  Console.WriteLine(valor);
}

// Sume todos los valores que son de tipo Int y genere la suma
int sum = 0;
foreach(object valor in objetos){
  if(valor is int){
    sum += (int)valor;
  }
}
Console.WriteLine($"La suma de los valores de tipo Int es {sum}");
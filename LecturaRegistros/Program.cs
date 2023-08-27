//LECTURA DE ENTRADA DE REGISTROS DE USUARIOS, EJERCICIO DE PRACTICA

Console.WriteLine("Hola, te voy ayudar a redactar una presentacion escrita.");
Console.WriteLine("Primero voy a almacenar tus datos. ");


//Nombre
Console.WriteLine("¿Como te llamas? (nombre y apellido con mayúsculas). ");
string nombre = Console.ReadLine();
Console.Clear();

//Edad
Console.WriteLine("¿Cuantos años tenés?");
int edad = Convert.ToInt32(Console.ReadLine());
Console.Clear();

//Trabajo actual
Console.WriteLine("¿De que trabajás actualmente?");
string trabajoActual = Console.ReadLine();
Console.Clear();

//Trabajo Ideal
Console.WriteLine("¿De que te gustaría trabajar en el futuro?");
string trabajoFuturo = Console.ReadLine();
Console.Clear();

//Redaccion
Console.WriteLine("Hola, me llamo "
    + nombre + " , tengo " + edad + " años, y actualmente trabajo de " + trabajoActual + "."
    +
" Tengo ganas de cambiar mi puesto de trabajo en el algun momento, me gustaria trabajar de "
+ trabajoFuturo + ".");

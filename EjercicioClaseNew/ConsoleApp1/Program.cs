using ConsoleApp1;

//Primer Objeto super heroe Batman
SuperHeroe Batman = new SuperHeroe("Batman", "Bruno Díaz", "Gotica", false);


SuperPoder _Batman = new SuperPoder("Intlecto", "Usa su intelecto", 5);
//Formato del encabezado acorde a la fila
string encabezado = "| {0,-15} | {1,-20} | {2,-15} | {3,-1} | {4,-15} | {5,-20} | {6,6} |";
// Imprimir según el formata establecido
Console.WriteLine(String.Format(encabezado, "Nombre", "Identidad Secreta", "Ciudad", "Puede Volar", "Super Poder", "Descripción", "Nivel"));
//Linea divisoria media
//Console.Write(new string('-', 98 ));
Batman.Imprimir();
//Linea divisoria baja
//Console.Write(new string('-', 98));
using ConsoleApp1;
// Batman
SuperPoder Intelecto = new SuperPoder("Intelecto", "Usa su intelecto", 5);
SuperHeroe Batman = new SuperHeroe("Batman", "Bruno Díaz", "Gotica", false, Intelecto);

// Linterna verde
SuperPoder luz = new SuperPoder("Semi-invulnerable", "Proyeccion de luz", 5);
SuperHeroe LinternaVerde = new SuperHeroe("Linterna verde", "Hal Jordan", "Sector2814", true, luz);

// Flash
SuperPoder Velocidad = new SuperPoder("Velocidad","Romper las leyes de la fisisca",5);
SuperHeroe Flash = new SuperHeroe("Flash", "Barry Allen", "Central City", false, Velocidad);

// Linea divisoria media
Console.Write(new string('-', 143));

// Formato del encabezado acorde a la fila
string encabezado = "\n| {0,-15} | {1,-20} | {2,-15} | {3,-15} | {4,-20} | {5,-30} | {6,6} |";

// Imprimir según el formato establecido
Console.WriteLine(String.Format(encabezado, "Nombre", "Identidad Secreta", "Ciudad", "Puede Volar", "Super Poder", "Descripción", "Nivel"));

// Imprimir los objetos según el preferencia
Batman.Imprimir();
LinternaVerde.Imprimir();
Flash.Imprimir();

// Linea divisoria baja
Console.Write(new string('-', 143));
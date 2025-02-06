

using EjercicioClase;

SuperPoder vuelo = new SuperPoder("Super Fuerza", "Capacidad de levantar objetos muy pesados", 9);
SuperPoder superfuerza = new SuperPoder("Superfuerza", "Tiene una fuerza sobrehumana", 6);
SuperPoder invisibilidad = new SuperPoder("Invisibilidad", "Puede hacerse invisible", 4);

SuperHeroe heroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, vuelo);
SuperHeroe heroe2 = new SuperHeroe("Hulk", "Bruce Banner", "New York", false, superfuerza);
SuperHeroe heroe3 = new SuperHeroe("Invisible Woman", "Sue Storm", "New York", false, invisibilidad);

MostrarInformacionHeroe(heroe1);
MostrarInformacionHeroe(heroe2); 
MostrarInformacionHeroe(heroe3);


static void MostrarInformacionHeroe(SuperHeroe heroe)
{
    Console.WriteLine($"Nombre: {heroe.Nombre}");
    Console.WriteLine($"Identidad Secreta: {heroe.IdentidadSecreta}");
    Console.WriteLine($"Ciudad: {heroe.Ciudad}");
    Console.WriteLine($"Puede Volar: {heroe.PuedeVolar}");
    Console.WriteLine($"Super Poder: {heroe.SuperPoder.Nombre}");
    Console.WriteLine($"Descripción: {heroe.SuperPoder.Descripcion}");
    Console.WriteLine($"Nivel: {heroe.SuperPoder.Nivel}");
    Console.WriteLine();
}
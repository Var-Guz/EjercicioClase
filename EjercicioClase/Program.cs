

using EjercicioClase;

SuperPoder vuelo = new SuperPoder("Vuelo", "Puede volar a gran velocidad", 5);
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
    Console.WriteLine($"SuperPoder: {heroe.SuperPoder.Nombre} - {heroe.SuperPoder.Descripcion} (Nivel {heroe.SuperPoder.Nivel})");
    Console.WriteLine();
}
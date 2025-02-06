
namespace EjercicioClase
{
    public class SuperPoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }

        public SuperPoder(string nombre, string descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Super Poder: {Nombre}");
            Console.WriteLine($"Descripcion : {Descripcion}");
            Console.WriteLine($"Nivel: {Nivel}");
       

         
        }

    }
}

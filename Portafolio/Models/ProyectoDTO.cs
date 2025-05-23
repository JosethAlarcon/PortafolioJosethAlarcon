namespace Portafolio.Models
{
    public class ProyectoDTO
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<string> Imagenes { get; set; } = new();
        public string Link { get; set; }
    }

}

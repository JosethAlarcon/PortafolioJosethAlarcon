using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() {
                new ProyectoDTO
            {
                Titulo = "BalanceFin Pro",
                Descripcion = "Proyecto realizado con React y TypeScript",
                Imagenes = new List<string>{
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",    
            },

                new ProyectoDTO
            {
                Titulo = "Gif Total",
                Descripcion = "Proyecto realizado con React y JavaScript",
                Imagenes = new List<string>{
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
                new ProyectoDTO
            {
                Titulo = "Balance",
                Descripcion = "Proyecto realizado con React y TypeScript",
                Imagenes = new List<string>{
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
                new ProyectoDTO
            {
                Titulo = "Balance",
                Descripcion = "Proyecto realizado con React y TypeScript",
                Imagenes = new List<string>{
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
                new ProyectoDTO
            {
                Titulo = "Balance",
                Descripcion = "Proyecto realizado con React y TypeScript",
                Imagenes = new List<string>{
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg",
                    "/imagenes/BalanceFin-Pro.jpg"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
            };
        }
    }
}

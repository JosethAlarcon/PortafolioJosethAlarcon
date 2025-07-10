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
                Titulo = "Vemuza Transpotes (Negocio Propio)",
                Descripcion = "Proyecto realizado con React, Javascript ASP.NET Core Web API y SQL Server." +
                " Permite reservar servicios de transporte de facil manera ademas de visualizar costos en tiempo real",
                Imagenes = new List<string>{
                    "/imagenes/Proyectos/1.png",
                    "/imagenes/Proyectos/2.png",
                    "/imagenes/Proyectos/3.png"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",    
            },

                new ProyectoDTO
            {
                Titulo = "Agenda Pro (Negocio Propio)",
                Descripcion = "Proyecto realizado en Android Studio con JAVA",
                Imagenes = new List<string>{
                    "/imagenes/Proyectos/4.png",
                    "/imagenes/Proyectos/5.png",
                    "/imagenes/Proyectos/6.png"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
                new ProyectoDTO
            {
                Titulo = "BalanceFin Pro",
                Descripcion = "Proyecto realizado con React y TypeScript para control de gastos personales",
                Imagenes = new List<string>{
                    "/imagenes/Proyectos/7.png",
                    "/imagenes/Proyectos/8.png",
                    "/imagenes/Proyectos/9.png"
                },
                Link = "https://balance-fin-pro-team-joseth.netlify.app/",
            },
                new ProyectoDTO
            {
                Titulo = "Gif Experto",
                Descripcion = "Proyecto realizado con React y Javascript que consume una API publica de gif" +
                " y permite buscarlos de forma personalizada a gusto del usuario",
                Imagenes = new List<string>{
                    "/imagenes/Proyectos/10.png",
                    "/imagenes/Proyectos/11.png",
                    "/imagenes/Proyectos/12.png"
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

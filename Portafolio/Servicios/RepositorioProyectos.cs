using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "BLOG",
                Descripcion = "Blog Cafe con Html", 
                Link = "https://blog-cafe-pv.netlify.app/",
                ImagenURL = "/imagenes/Blog.JPEG"
            },
                new Proyecto
            {
                Titulo = "Front-End Store",
                Descripcion = "Tienda Viertual",
                Link = "https://tienda-virtual-ejemplo.netlify.app/",
                ImagenURL = "/imagenes/tienda.jpg"
            },
                new Proyecto
            {
                Titulo = "Freelancer",
                Descripcion = "Proyecto en HTML y CSS",
                Link = "https://boisterous-lily-5421f3.netlify.app/",
                ImagenURL = "/imagenes/Freelancer.jpeg"
            },
                new Proyecto
            {
                Titulo = "Crud",
                Descripcion = "Crud ASP .Net MVC",
                Link = "https://github.com/VASPABLO/ProyectoCrudNet8MVC",
                ImagenURL = "/imagenes/crud.jpeg"
            },
            };
        }
    }
}

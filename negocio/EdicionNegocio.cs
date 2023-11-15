using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class EdicionNegocio
    {
        // Nos trae una lista de tipos de edición de la base de datos.
        public List<Edicion> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Edicion> listaEdicion = new List<Edicion>();
                datos.setearConsulta("select Id, Descripcion from TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Edicion aux = new Edicion();

                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Descripcion = datos.Lector.GetString(1);

                    listaEdicion.Add(aux);
                }


                return listaEdicion;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
    }
}

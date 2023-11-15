using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {

                conexion.ConnectionString = " server = .\\SQLEXPRESS; database=DISCOS_DB; integrated security = true"; // Describimos la base de datos a la que nos queremos conectar.
                comando.CommandType = System.Data.CommandType.Text; // Tipo de comando (texto)
                comando.CommandText = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, e.Descripcion Estilo, t.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id From DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and T.Id = D.IdTipoEdicion"; //consulta Sql.
                comando.Connection = conexion; // Establecemos la conexión del comando con la base de datos.

                conexion.Open(); // Abrimos conexión.
                lector = comando.ExecuteReader(); // Ejecutamos la acción.

                while (lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Titulo = lector.GetString(0);
                    aux.FechaLanzamiento = lector.GetDateTime(1);
                    aux.CantidadCanciones = lector.GetInt32(2);
                    if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                        aux.UrlImagenTapa = lector.GetString(3);
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = lector.GetString(4);
                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.Descripcion = lector.GetString(5);
                    aux.Estilo.Id = lector.GetInt32(6);
                    aux.TipoEdicion.Id = lector.GetInt32(7);
                    aux.Id = lector.GetInt32(8);
                    
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregarDisco(Disco disco)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("insert into DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, IdEstilo, IdTipoEdicion, UrlImagenTapa) values(@Titulo, @FechaLanzamiento, @CantidadCanciones, @IdEstilo, @IdTipoEdicion, @UrlImagenTapa)");
                acceso.agregarParametros("@Titulo", disco.Titulo);
                acceso.agregarParametros("@FechaLanzamiento", disco.FechaLanzamiento);
                acceso.agregarParametros("@CantidadCanciones", disco.CantidadCanciones);
                acceso.agregarParametros("@IdEstilo", disco.Estilo.Id);
                acceso.agregarParametros("@IdTipoEdicion", disco.TipoEdicion.Id);
                acceso.agregarParametros("@UrlImagenTapa", disco.UrlImagenTapa);
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }

        }
        
        public void modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento, CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlImagenTapa, IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion where Id = @Id");
                datos.agregarParametros("@Titulo", disco.Titulo);
                datos.agregarParametros("@FechaLanzamiento", disco.FechaLanzamiento);
                datos.agregarParametros("@CantidadCanciones", disco.CantidadCanciones);
                datos.agregarParametros("@UrlImagenTapa", disco.UrlImagenTapa);
                datos.agregarParametros("@IdEstilo", disco.Estilo.Id);
                datos.agregarParametros("@IdTipoEdicion", disco.TipoEdicion.Id);
                datos.agregarParametros("Id", disco.Id);
                datos.ejecutarAccion();

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

        public void eliminarDiscoFisicamente (int id)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("delete from discos where Id = @Id");
                acceso.agregarParametros("@Id", id);
                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();                 
            }
        }

        public List<Disco> filtroAvanzado(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, e.Descripcion Estilo, t.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id From DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and T.Id = D.IdTipoEdicion and ";
            try
            {
                if (campo == "Nombre del disco")
                {
                    switch (criterio)
                    {
                        case ("Empieza con"):
                            consulta += "Titulo like '" + filtro + "%'";
                            break;
                        case ("Termina con"):
                            consulta += "Titulo like '%" + filtro +"'";
                            break;
                        case ("Contiene"):
                            consulta += "Titulo like '%" + filtro + "%'";
                            break;
                    }
                } 
                else if (campo == "Año de lanzamiento")
                {
                    switch (criterio)
                    {
                        case ("Despues del"):
                            consulta += "FechaLanzamiento >= '01/01/" + filtro + "'";
                        break;
                        case ("Antes del"):
                            consulta += "FechaLanzamiento <= '12/31/" + filtro + "'";
                        break;
                        case ("Año exacto"):
                            consulta += "FechaLanzamiento >= '01/01/" + filtro + "'" + " and FechaLanzamiento <= '12/31/" + (filtro) + "'";
                        break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case ("Pop Punk"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Pop"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Rock"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Grunge"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Phonk"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Clasica"):
                            consulta += "e.Descripcion = '" + filtro + "'";
                        break;
                        case ("Todos"):
                            consulta = "select Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, e.Descripcion Estilo, t.Descripcion Edicion, D.IdEstilo, D.IdTipoEdicion, D.Id From DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and T.Id = D.IdTipoEdicion";
                        break;
                    }
                }


                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Titulo = datos.Lector.GetString(0);
                    aux.FechaLanzamiento = datos.Lector.GetDateTime(1);
                    aux.CantidadCanciones = datos.Lector.GetInt32(2);
                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagenTapa"))))
                        aux.UrlImagenTapa = datos.Lector.GetString(3);
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = datos.Lector.GetString(4);
                    aux.TipoEdicion = new Edicion();
                    aux.TipoEdicion.Descripcion = datos.Lector.GetString(5);
                    aux.Estilo.Id = datos.Lector.GetInt32(6);
                    aux.TipoEdicion.Id = datos.Lector.GetInt32(7);
                    aux.Id = datos.Lector.GetInt32(8);

                    lista.Add(aux);
                }

                return lista;

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

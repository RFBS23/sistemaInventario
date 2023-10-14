using entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public class D_Productos
    {

        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tallaxs, tallas, tallam, tallal, tallaxl, tallaxxl, colores, precioventa from productos p");
                    query.AppendLine("inner join categorias c on c.idcategoria = p.idcategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Productos()
                            {
                                idproducto = Convert.ToInt32(dr["idproducto"]),
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                oCategorias = new Categorias() { idcategoria = Convert.ToInt32(dr["idcategoria"]), nombrecategoria = dr["nombrecategoria"].ToString() },
                                tallaxs = Convert.ToInt32(dr["tallaxs"].ToString()),
                                tallas = Convert.ToInt32(dr["tallas"].ToString()),
                                tallam = Convert.ToInt32(dr["tallam"].ToString()),
                                tallal = Convert.ToInt32(dr["tallal"].ToString()),
                                tallaxl = Convert.ToInt32(dr["tallaxl"].ToString()),
                                tallaxxl = Convert.ToInt32(dr["tallaxxl"].ToString()),
                                colores = dr["colores"].ToString(),
                                precioventa = Convert.ToDecimal(dr["precioventa"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Productos>();
                }
            }
            return lista;
        }

        public int Registrar(Productos obj, out string Mensaje)
        {
            int idproductogenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_productos", oconexion);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idcategoria", obj.oCategorias.idcategoria);
                    cmd.Parameters.AddWithValue("tallaxs", obj.tallaxs);
                    cmd.Parameters.AddWithValue("tallas", obj.tallas);
                    cmd.Parameters.AddWithValue("tallam", obj.tallam);
                    cmd.Parameters.AddWithValue("tallal", obj.tallal);
                    cmd.Parameters.AddWithValue("tallaxl", obj.tallaxl);
                    cmd.Parameters.AddWithValue("tallaxxl", obj.tallaxxl);
                    cmd.Parameters.AddWithValue("colores", obj.colores);
                    cmd.Parameters.AddWithValue("precioventa", obj.precioventa);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idproductogenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idproductogenerado = 0;
                Mensaje = ex.Message;
            }
            return idproductogenerado;
        }

        public bool Editar(Productos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_editar_productos", oconexion);
                    cmd.Parameters.AddWithValue("idproducto", obj.idproducto);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idcategoria", obj.oCategorias.idcategoria);
                    cmd.Parameters.AddWithValue("tallaxs", obj.tallaxs);
                    cmd.Parameters.AddWithValue("tallas", obj.tallas);
                    cmd.Parameters.AddWithValue("tallam", obj.tallam);
                    cmd.Parameters.AddWithValue("tallal", obj.tallal);
                    cmd.Parameters.AddWithValue("tallaxl", obj.tallaxl);
                    cmd.Parameters.AddWithValue("tallaxxl", obj.tallaxxl);
                    cmd.Parameters.AddWithValue("colores", obj.colores);
                    cmd.Parameters.AddWithValue("precioventa", obj.precioventa);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

        public bool Eliminar(Productos obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_eliminar_productos", oconexion);
                    cmd.Parameters.AddWithValue("idproducto", obj.idproducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;
        }

    }
}

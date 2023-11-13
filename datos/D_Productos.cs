using entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
                    query.AppendLine("select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, devolucion, devoluciontalla from productosropa p");
                    query.AppendLine("inner join categorias c on c.idcategoria = p.idcategoria");
                    query.AppendLine("inner join tallasropa tr on tr.idtallaropa = p.idtallaropa");

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
                                oTallasropa = new Tallasropa() { idtallaropa = Convert.ToInt32(dr["idtallaropa"]), nombretalla = dr["nombretalla"].ToString() },
                                colores = dr["colores"].ToString(),
                                stock = Convert.ToInt32(dr["stock"]),
                                numcaja = dr["numcaja"].ToString(),
                                precioventa = Convert.ToDecimal(dr["precioventa"]),
                                devolucion = dr["devolucion"].ToString(),
                                devoluciontalla = dr["devoluciontalla"].ToString()
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
                    SqlCommand cmd = new SqlCommand("spu_registrar_productoropa", oconexion);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idcategoria", obj.oCategorias.idcategoria);
                    cmd.Parameters.AddWithValue("idtallaropa", obj.oTallasropa.idtallaropa);
                    cmd.Parameters.AddWithValue("colores", obj.colores);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("numcaja", obj.numcaja);
                    cmd.Parameters.AddWithValue("precioventa", obj.precioventa);
                    cmd.Parameters.AddWithValue("devolucion", obj.devolucion);
                    cmd.Parameters.AddWithValue("devoluciontalla", obj.devoluciontalla);
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
                    SqlCommand cmd = new SqlCommand("spu_editar_productoropa", oconexion);
                    cmd.Parameters.AddWithValue("idproducto", obj.idproducto);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("idcategoria", obj.oCategorias.idcategoria);
                    cmd.Parameters.AddWithValue("idtallaropa", obj.oTallasropa.idtallaropa);
                    cmd.Parameters.AddWithValue("colores", obj.colores);
                    cmd.Parameters.AddWithValue("stock", obj.stock);
                    cmd.Parameters.AddWithValue("numcaja", obj.numcaja);
                    cmd.Parameters.AddWithValue("precioventa", obj.precioventa);
                    cmd.Parameters.AddWithValue("devolucion", obj.devolucion);
                    cmd.Parameters.AddWithValue("devoluciontalla", obj.devoluciontalla);
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
                    SqlCommand cmd = new SqlCommand("spu_eliminar_productoropa", oconexion);
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

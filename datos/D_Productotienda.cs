using entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace datos
{
    public class D_Productotienda
    {
        public int obtenercorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from productosropatienda");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());

                } catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        public List<Productostienda> Listar()
        {
            List<Productostienda> lista = new List<Productostienda>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT dt.iddetalletienda, dt.idproductotienda, pr.idproducto, pr.codigo, pr.nombre, pr.descripcion, cat.idcategoria, cat.nombrecategoria, tr.idtallaropa, tr.nombretalla, pr.stock, pr.colores, pr.numcaja, pr.precioventa, pr.devolucion, pr.devoluciontalla, pr.estado AS estado_producto, pr.fecharegistro AS fecharegistro_producto, dt.cantidad, convert(varchar(12), dt.fecharegistro, 120) AS fecharegistro_detalletienda FROM detalletienda dt");
                    query.AppendLine("JOIN productosropa pr ON dt.idproducto = pr.idproducto");
                    query.AppendLine("JOIN categorias cat ON pr.idcategoria = cat.idcategoria");
                    query.AppendLine("JOIN tallasropa tr ON pr.idtallaropa = tr.idtallaropa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Productostienda()
                            {
                                oDetallestienda = new List<Detallestienda>()
                                {
                                    new Detallestienda()
                                    {
                                        iddetalletienda = Convert.ToInt32(dr["iddetalletienda"]),
                                        oProductos = new Productos()
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
                                            devoluciontalla = dr["devoluciontalla"].ToString(),
                                        },
                                        cantidad = Convert.ToInt32(dr["cantidad"]),
                                        fecharegistro = Convert.ToString(dr["fecharegistro_detalletienda"])
                                    }
                                },
                                idproductotienda = Convert.ToInt32(dr["idproductotienda"]),
                                oProductos = new Productos()
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
                                    devoluciontalla = dr["devoluciontalla"].ToString(),
                                },
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                fecharegistro = Convert.ToString(dr["fecharegistro_detalletienda"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Productostienda>();
                    // Manejo de excepciones, puedes agregar lógica para registrar el error si es necesario.
                }
            }
            return lista;
        }

        public bool Registrar(Productostienda obj, DataTable detalletienda, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_productosropatienda", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@idusuario", obj.oUsuarios.idusuario);
                    cmd.Parameters.AddWithValue("@cantidad", obj.cantidad);
                    cmd.Parameters.AddWithValue("@fecharegistro", obj.fecharegistro);

                    // Parámetros de salida
                    cmd.Parameters.Add("@resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    // Parámetro de tabla tipo usuario
                    SqlParameter detalletiendaParam = cmd.Parameters.AddWithValue("@detalletienda", detalletienda);
                    detalletiendaParam.SqlDbType = SqlDbType.Structured;
                    detalletiendaParam.TypeName = "dbo.Edetalletienda";  // Ajusta según el nombre de tu tipo de tabla

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@resultado"].Value);
                    Mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

    }
}

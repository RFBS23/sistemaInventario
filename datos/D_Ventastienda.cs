using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entidad;

namespace datos
{
    public class D_Ventastienda
    {
        public int obtenercorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from ventas");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        public bool RestarStock(int iddetalletienda, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update detalletienda set cantidad = cantidad - @cantidad where iddetalletienda = @iddetalletienda;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@iddetalletienda", iddetalletienda);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int iddetalletienda, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update detalletienda set cantidad = cantidad + @cantidad where iddetalletienda = @iddetalletienda;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@iddetalletienda", iddetalletienda);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool registrar(Ventas_Tienda obj, DataTable detalleventatienda, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_ventatienda", oconexion);
                    cmd.Parameters.AddWithValue("idusuario", obj.oUsuarios.idusuario);
                    cmd.Parameters.AddWithValue("tipodocumento", obj.tipodocumento);
                    cmd.Parameters.AddWithValue("numerodocumento", obj.numerodocumento);
                    cmd.Parameters.AddWithValue("documentocliente", obj.documentocliente);
                    cmd.Parameters.AddWithValue("nombrecliente", obj.nombrecliente);
                    cmd.Parameters.AddWithValue("montopago", obj.montopago);
                    cmd.Parameters.AddWithValue("montocambio", obj.montocambio);
                    cmd.Parameters.AddWithValue("montototal", obj.montototal);
                    cmd.Parameters.AddWithValue("detalleventatienda", detalleventatienda);

                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }

        public Ventas ObtenerVentaTienda(string numero)
        {
            Ventas obj = new Ventas();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select vt.idventatienda, u.nombreusuario, vt.documentocliente, vt.nombrecliente, vt.tipodocumento,");
                    query.AppendLine("vt.numerodocumento, vt.montopago, vt.montocambio, vt.montototal, convert(char(10), vt.fecharegistro, 103)[FechaRegistro] from ventastienda vt");
                    query.AppendLine("inner join usuarios u on u.idusuario = v.idusuario");
                    query.AppendLine("where vt.numerodocumento = @numero");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Ventas()
                            {
                                idventa = int.Parse(dr["idventatienda"].ToString()),
                                oUsuarios = new Usuarios() { nombreusuario = dr["nombreusuario"].ToString() },
                                documentocliente = dr["documentocliente"].ToString(),
                                nombrecliente = dr["nombrecliente"].ToString(),
                                tipodocumento = dr["tipodocumento"].ToString(),
                                numerodocumento = dr["numerodocumento"].ToString(),
                                montopago = Convert.ToDecimal(dr["montopago"].ToString()),
                                montocambio = Convert.ToDecimal(dr["montocambio"].ToString()),
                                montototal = Convert.ToDecimal(dr["montototal"].ToString()),
                                fecharegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    obj = new Ventas();
                }
            }
            return obj;
        }

        public List<Detalle_ventatienda> ObtenerDetallesVentaTienda(int idventatienda)
        {
            List<Detalle_ventatienda> oLista = new List<Detalle_ventatienda>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select pt.idproductotienda, dvt.precioventa, dvt.cantidad, dvt.subtotal from detalle_ventatienda dvt");
                    query.AppendLine("inner join productosropatienda pt on pt.idproductotienda = dvt.idproductotienda");
                    query.AppendLine("where dvt.idventatienda = @idventatienda");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idventatienda", idventatienda);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Detalle_ventatienda()
                            {
                                //oProductostienda = new Productostienda() { nombre = dr["nombre"].ToString() },
                                precioventa = Convert.ToDecimal(dr["precioventa"].ToString()),
                                cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                                subtotal = Convert.ToDecimal(dr["subtotal"].ToString())
                            });
                        }
                    }
                }
                catch
                {
                    oLista = new List<Detalle_ventatienda>();
                }
            }
            return oLista;
        }

    }
}

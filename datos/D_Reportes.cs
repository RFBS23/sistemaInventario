using entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    public  class D_Reportes
    {
        public List<ReporteVenta> Ventas(string fechainicio, string fechafin)
        {
            List<ReporteVenta> lista = new List<ReporteVenta> ();
            using (SqlConnection oconexion = new SqlConnection (Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("spu_reporte_venta", oconexion);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                tipodocumento = dr["tipodocumento"].ToString(),
                                numerodocumento = dr["numerodocumento"].ToString(),
                                montototal = dr["montototal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                documentocliente = dr["documentocliente"].ToString(),
                                nombrecliente = dr["nombrecliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                precioventa = dr["precioventa"].ToString(),
                                cantidad = dr["cantidad"].ToString(),
                                subtotal = dr["subtotal"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReporteVenta>();
                }
            }
            return lista;
        }
    }
}

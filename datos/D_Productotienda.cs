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
    public class D_Productotienda
    {
        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idproducto, codigo, nombre, descripcion, c.idcategoria, c.nombrecategoria, tr.idtallaropa, tr.nombretalla, stock, colores, numcaja, precioventa, temporada, descuento, total, ubicacion, CONVERT(VARCHAR(10), p.fecharegistro, 120)AS fecharegistro_producto from productosropa p");
                    query.AppendLine("inner join categorias c on c.idcategoria = p.idcategoria");
                    query.AppendLine("inner join tallasropa tr on tr.idtallaropa = p.idtallaropa");
                    query.AppendLine("where ubicacion = 'Tienda'");

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
                                temporada = dr["temporada"].ToString(),
                                descuento = Convert.ToInt32(dr["descuento"]),
                                total = Convert.ToDecimal(dr["total"]),
                                ubicacion = dr["ubicacion"].ToString(),
                                fecharegistro = dr["fecharegistro_producto"].ToString()
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
          
    }
}

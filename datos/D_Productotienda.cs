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
    public class D_Productotienda
    {
        public List<Productostienda> Listar()
        {
            List<Productostienda> lista = new List<Productostienda>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idproductotienda, pa.idproducto, pa.codigo, pa.nombre, pa.descripcion, pa.idcategoria, c.nombrecategoria, pa.idtallaropa, tr.nombretalla, pa.stock, pa.colores, pa.numcaja, pa.precioventa from productosropatienda pt");
                    query.AppendLine("inner join productosropa pa on pa.idproducto = pt.idproductotienda");
                    query.AppendLine("inner join categorias c on c.idcategoria = pa.idcategoria");
                    query.AppendLine("inner join tallasropa tr on tr.idtallaropa = pa.idtallaropa");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Productostienda()
                            {
                                idproductotienda = Convert.ToInt32(dr["idproductotienda"]),
                                oProductos = new Productos() {
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
                                },
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Productostienda>();
                }
            }
            return lista;
        }
    }
}

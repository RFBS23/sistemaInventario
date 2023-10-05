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
    public class D_Tallas
    {
        public List<Tallas> Listar()
        {
            List<Tallas> lista = new List<Tallas>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idtalla, nombretalla, tipo_prenda from tallas");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Tallas()
                            {
                                idtalla = Convert.ToInt32(dr["idtalla"]),
                                nombretalla = dr["nombretalla"].ToString(),
                                tipo_prenda = dr["tipo_prenda"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Tallas>();
                }
            }
            return lista;
        }
    }
}

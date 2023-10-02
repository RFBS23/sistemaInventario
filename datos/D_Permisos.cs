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
    public class D_Permisos
    {
        public List<Permisos> Listar(int idusuario)
        {
            List<Permisos> lista = new List<Permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.idrol, p.nombremenu from permisos p");
                    query.AppendLine("inner join rol r on r.idrol = p.idrol");
                    query.AppendLine("inner join usuarios u on u.idrol = r.idrol");
                    query.AppendLine("where u.idusuario =  @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                oRol = new Rol() { idrol = Convert.ToInt32(dr["idrol"]) },
                                nombremenu = dr["nombremenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permisos>();
                }
            }
            return lista;
        }
    }
}

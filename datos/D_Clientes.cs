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
    public class D_Clientes
    {
        public List<Clientes> Listar()
        {
            List<Clientes> lista = new List<Clientes>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idcliente, documento, nombres, apellidos, correo, telefono from clientes");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Clientes()
                            {
                                idcliente = Convert.ToInt32(dr["idcliente"]),
                                documento = dr["documento"].ToString(),
                                nombres = dr["nombres"].ToString(),
                                apellidos = dr["apellidos"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Clientes>();
                }
            }
            return lista;
        }
    }
}

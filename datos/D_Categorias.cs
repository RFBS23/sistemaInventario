using entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace datos
{
    public class D_Categorias
    {
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select idcategoria, nombrecategoria from categorias");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categorias()
                            {
                                idcategoria = Convert.ToInt32(dr["idcategoria"]),
                                nombrecategoria = dr["nombrecategoria"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categorias>();
                }
            }
            return lista;
        }

        public int Registrar(Categorias obj, out string Mensaje)
        {
            int idcategoriagenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("spu_registrar_categoria", oconexion);

                    cmd.Parameters.AddWithValue("nombrecategoria", obj.nombrecategoria);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                }
            } catch (Exception ex)
            {
                idcategoriagenerado = 0;
                Mensaje = ex.Message;
            }
            return idcategoriagenerado;
        }
    }
}

using System;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;


namespace Sistema.Datos
{
    public class DPromedio
    {

        public DataTable calculoPromedio(int Valore, int Valora)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("calificacion_calcular", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ide", SqlDbType.Int).Value = Valore;
                Comando.Parameters.Add("@ida", SqlDbType.Int).Value = Valora;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //public float calculoPromedio(int Valor)
        //{
        //    SqlDataReader Resultado;
        //    //DataTable Tabla = new DataTable();
        //    SqlConnection SqlCon = new SqlConnection();
        //    float promedio=0;
        //    String msgt;
        //    try
        //    {
        //        SqlCon = Conexion.getInstancia().CrearConexion();
        //        SqlCommand Comando = new SqlCommand("calificacion_calcular", SqlCon);
        //        Comando.CommandType = CommandType.StoredProcedure;
        //        Comando.Parameters.Add("@vid", SqlDbType.Int).Value = Valor;




        //       SqlCon.Open();
        //        Resultado = Comando.ExecuteReader();
        //       // float promedio;
        //        while (Resultado.Read())
        //        {



        //             promedio = Resultado.GetFloat(1);
        //           // return promedio;

        //        }      
        //        //Tabla.Load(Resultado);
        //        //return null;
        //    }

        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }

        //    return promedio;
        //}

    }
}

using System;

namespace _04_Capa_AcessoDatos
{
    public class DA_Cliente
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        // Propiedaddes
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DA_Cliente (string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // métodos
        public int Insertar(EntidadCliente cliente)
        {
            int id = 0;
            //Establecer el objeto de conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer los comandos SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string sentencia = "INSERT INTO CLIENTES (NOMBRE, TELEFONO , DIRECCION)"
                + "VALUES(@NOMBRE, @TELEFONO,@DIRECCION) SELECT @@IDENTITY";
            comandoParameters.AddWhithValue("@NOMBRE", cliente.Nombre);
            comandoParameters.AddWhithValue("@TELEFONO", cliente.Telefono);
            comandoParameters.AddWhithValue("@NOMBRE", cliente.Direccion);
            comando.CommandText = sentencia;

            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                cnx.Dispose();
                comando.Disponse();

            }

            return id;
        }// fin de insertar

    } //Fin clase
} // fin namespace

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class comentariosAccesoDatos //colocar como publica para que pueda trabajar con otros proyectos
    {
        //ESTO ES SIN CONECTAR A BD
        //public List<Comentario> comentarios;

        //CON BD
        private string cadena = "Server=DESKTOP-DTQ8UHN\\SQLEXPRESS;Database=basePresentacion;Trusted_Connection=True;";
        

        public comentariosAccesoDatos()// agrego un contructor con "ctor" para poder despues agregar y devolver comentarios
        {
            //comentarios = new List<Comentario>();
        }

        public bool AgregarComentario(Comentario comentario) //insertar los comentarios en la base de datos
        {
            string consulta = $@"INSERT INTO Comentarios(Nombre,Texto)
                                VALUES('{comentario.Nombre}','{comentario.Texto}')";

            int resultado;
            //CON EL USING EVITO ESTAR CERRANDO CADA CONEXION Y LO HACE MAS OPTIMO
            using (SqlConnection conexion = new SqlConnection(cadena)) 
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    //esto nos devolvera cuantos registros fueron afectados
                    resultado = comando.ExecuteNonQuery();//significa que no es una consulta ya que "insertar" no lo es
                    
                }
            }
            
           
            if (resultado==1)//para verificar que se haya ingresado en la BD
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public List<Comentario> ObtenerComentarios() // retorno los comentarios enviados
        {
            List<Comentario> resultado = new List<Comentario>();

            //PARA TRAER LOS COMENTARIOS DE LA BD
            string consulta = "SELECT Id,Nombre,Texto FROM Comentarios";//si la consulta es muy grande puedo
            //colocar un "@" al principio

            using(SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();//abrir conexion
                    SqlDataReader reader = comando.ExecuteReader();//accion para leer y ejecutar la tabla

                    while (reader.Read()) //despues de seleccionar alguna, pasa a la siguiente
                    {
                        Comentario comentario = new Comentario()
                        {
                            Id = reader.GetInt32(0),
                            //indica los datos a leer
                            Nombre = reader.GetString(1),
                            //otra forma de llamar
                            Texto = reader["Texto"].ToString()//le coloco el Tostring() porque sino lo toma como objet
                        };
                        resultado.Add(comentario);//se añade a la lista de comentarios
                    }
                    //reader.Close();//siempre cerrar el reader
                    //conexion.Close();//cerrar conexion
                }
            }
            ;
            

            return resultado; 
        }
        public bool BorrarComentario(int id)
        {
            string consulta = $@"DELETE FROM Comentarios
                                WHERE Id={id}";

            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }
            if (resultado == 1)//para verificar que se haya ingresado en la BD
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

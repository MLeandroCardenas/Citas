using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;


public class DAO_Usuarios
{
    public DAO_Usuarios()
    {
        
    }

    public Boolean validarexistencia(E_DatosUser user)
    {
        Int64 contador = 0;

        try
        {
            NpgsqlConnection cn = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            cn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM usuarios WHERE email = @email OR identificacion = @identificacion");
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@identificacion", user.Clave);
            contador = (Int64)cmd.ExecuteScalar();
            cn.Close();
        }
        catch (Exception ex)
        {
            
        }
        return contador > 0;
        
    }

    public void CrearUsuarios(E_DatosUser usuarios)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        if (!validarexistencia(usuarios))
        {
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_insertaruser", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_apellidos", NpgsqlDbType.Text).Value = usuarios.Apellidos;
                dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Text).Value = usuarios.Nombres;
                dataAdapter.SelectCommand.Parameters.Add("_identificacion", NpgsqlDbType.Integer).Value = usuarios.Numid;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = usuarios.Email;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuarios.Clave;
                dataAdapter.SelectCommand.Parameters.Add("_rol", NpgsqlDbType.Integer).Value = 3;
                dataAdapter.SelectCommand.Parameters.Add("_sesion", NpgsqlDbType.Text).Value = usuarios.Session;
                dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = 1;
                dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = usuarios.Foto;
                dataAdapter.SelectCommand.Parameters.Add("_url", NpgsqlDbType.Text).Value = usuarios.Url;

                conection.Open();
                dataAdapter.Fill(user);
            }
            catch (Exception Ex)
            {
                
            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
        }
      }
    }

    public DataTable loggin(E_DatosUser usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_loggin", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_identificacion", NpgsqlDbType.Integer).Value = usuario.Numid;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuario.Clave;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable guardadoSession(E_usuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_guardado_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar, 100).Value = datos.Ip;
            dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar, 100).Value = datos.Mac;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable actualizarContrasena(E_usuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_actualizar_contrasena", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable cerrarSession(E_usuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_cerrar_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable generarToken(Int64 identificacion)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_identificacion", NpgsqlDbType.Integer).Value = identificacion;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable almacenarToken(String token, Int32 userId)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_almacenar_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsusarioToken(String token)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_obtener_usuario_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsuarios(int userid)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_userid", NpgsqlDbType.Integer).Value = userid;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public void editarperfil(E_DatosUser usuarios)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
 
            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_editarperfil", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_id_admin", NpgsqlDbType.Integer).Value = usuarios.Session;
                dataAdapter.SelectCommand.Parameters.Add("_apellidos", NpgsqlDbType.Text).Value = usuarios.Apellidos;
                dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Text).Value = usuarios.Nombres;
                dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = usuarios.Email;
                dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuarios.Clave;

                conection.Open();
                dataAdapter.Fill(user);
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                if (conection != null)
                {
                    conection.Close();
                }
            }
        }
    }

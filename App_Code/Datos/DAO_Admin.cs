using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAO_Admin
/// </summary>
public class DAO_Admin
{
    
    public DAO_Admin()
    {
    }

    public void CrearEspecialidad(string especialidad, string sesion)
    {
        
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("medico.f_crearespecialidad", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_especialidad", NpgsqlDbType.Text).Value = especialidad;
                dataAdapter.SelectCommand.Parameters.Add("_sesion", NpgsqlDbType.Text).Value = sesion;
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


    public void CrearMedico(E_DatosUser medico)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_crearmedico", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_apellidos", NpgsqlDbType.Text).Value = medico.Apellidos;
            dataAdapter.SelectCommand.Parameters.Add("_nombres", NpgsqlDbType.Text).Value = medico.Nombres;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = medico.Numid;
            dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = medico.Email;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = medico.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_rol", NpgsqlDbType.Integer).Value = medico.Rol;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = medico.Estado;
            dataAdapter.SelectCommand.Parameters.Add("_sesion", NpgsqlDbType.Text).Value = medico.Session;
            dataAdapter.SelectCommand.Parameters.Add("_especializacion", NpgsqlDbType.Text).Value = medico.Especializacion1;
            dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = medico.Foto;
            dataAdapter.SelectCommand.Parameters.Add("_url", NpgsqlDbType.Text).Value = medico.Url;

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

    public DataTable obtenerespecialidad()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("medico.f_obtenerespecialidades", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

    public DataTable obtenerespecialidadDos()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(" medico.f_obtenerespecialidadesdos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

    public DataTable obtenermedicos()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("administrador.f_obtener_medicos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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


    public void eliminarMedico(int id)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("administrador.f_borrarmedicos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            
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

    public DataTable obtenerpacientes()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("administrador.f_obtener_pacientes", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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

    public void eliminarPacientes(int id)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("administrador.f_borrarpacientes", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

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

    public void eliminarespecialidad(int id)
    {
        DataTable user = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(connectionString: ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("administrador.f_borrarespecialidades", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

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
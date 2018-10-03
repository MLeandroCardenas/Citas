using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DatosUsuarios
/// </summary>
public class E_DatosUser
{
    string apellidos;
    string nombres;
    Int64 numid;
    string email;
    string clave;
    string Especializacion;
    int rol;
    string confirmarCorreo;
    string confirmarClave;
    int estado;
    string session;
    string foto;
    string url;



    public E_DatosUser()
    {
        
    }

    public string Apellidos
    {
        get
        {
            return apellidos;
        }

        set
        {
            apellidos = value;
        }
    }

    public string Nombres
    {
        get
        {
            return nombres;
        }

        set
        {
            nombres = value;
        }
    }

    public long Numid
    {
        get
        {
            return numid;
        }

        set
        {
            numid = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }


    public string Clave
    {
        get
        {
            return clave;
        }

        set
        {
            clave = value;
        }
    }



    public string Especializacion1
    {
        get
        {
            return Especializacion;
        }

        set
        {
            Especializacion = value;
        }
    }

    public int Rol
    {
        get
        {
            return rol;
        }

        set
        {
            rol = value;
        }
    }

    public string ConfirmarCorreo
    {
        get
        {
            return confirmarCorreo;
        }

        set
        {
            confirmarCorreo = value;
        }
    }

    public string ConfirmarClave
    {
        get
        {
            return confirmarClave;
        }

        set
        {
            confirmarClave = value;
        }
    }

    public int Estado
    {
        get
        {
            return estado;
        }

        set
        {
            estado = value;
        }
    }

    public string Session
    {
        get
        {
            return session;
        }

        set
        {
            session = value;
        }
    }

    public string Foto
    {
        get
        {
            return foto;
        }

        set
        {
            foto = value;
        }
    }

    public string Url
    {
        get
        {
            return url;
        }

        set
        {
            url = value;
        }
    }
}
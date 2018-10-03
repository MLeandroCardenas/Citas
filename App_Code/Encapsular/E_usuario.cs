using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de E_usuario
/// </summary>
public class E_usuario
{

    private Int32 userId;
    private String session;
    private String ip;
    private String mac;
    private String clave;
    private int rolId;


    public E_usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int UserId
    {
        get
        {
            return userId;
        }

        set
        {
            userId = value;
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

    public string Ip
    {
        get
        {
            return ip;
        }

        set
        {
            ip = value;
        }
    }

    public string Mac
    {
        get
        {
            return mac;
        }

        set
        {
            mac = value;
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

    public int RolId
    {
        get
        {
            return rolId;
        }

        set
        {
            rolId = value;
        }
    }
}
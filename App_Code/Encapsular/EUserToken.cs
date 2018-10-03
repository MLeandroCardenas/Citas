using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EUserToken
/// </summary>
public class EUserToken
{

    private Int32 id;
    private String correo;
    private Int64 identificacion;
    private Int32 estado;
    private long fecha;


    public EUserToken()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public string Correo
    {
        get
        {
            return correo;
        }

        set
        {
            correo = value;
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

    public long Fecha
    {
        get
        {
            return fecha;
        }

        set
        {
            fecha = value;
        }
    }

    public long Identificacion
    {
        get
        {
            return identificacion;
        }

        set
        {
            identificacion = value;
        }
    }
}
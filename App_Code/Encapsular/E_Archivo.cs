using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de E_Archivo
/// </summary>
public class E_Archivo
{

    private string imagen;
    private string url;


    public E_Archivo()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public string Imagen
    {
        get
        {
            return imagen;
        }

        set
        {
            imagen = value;
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
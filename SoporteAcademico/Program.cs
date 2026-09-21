
    bool ValidarCodigo(string codigo, int longitudMin)
    {
    if (codigo == "")
    {
        return false;
    }
    if (codigo.Length < longitudMin)
    {
        return false;
    }
    if (codigo[0] != 'N')
    {
        return false;
    }
     if (codigo[1] != '0' || codigo[2] != '0')
    {
        return false;
    }


    bool restoSonDigitos = true;
    for (int i = 1; i < codigo.Length; i++)
    {
        if (codigo[i] < '0' || codigo[i] > '9')
        {
            restoSonDigitos = false;
        }
    }

    return restoSonDigitos;
    }

    bool ValidarTipoConsulta(string tipoconsulta)
    {
        return true;
    }
    
    bool RegistrarDatos(string codigo, string nombre, string tipoconsulta, string descripcionbreve)
    {
        int longitudMin = 8;
        bool esBoleano1 = (ValidarCodigo(codigo, longitudMin)==true) && (ValidarTipoConsulta(tipoconsulta)==true);
        return esBoleano1;
    }


    bool esCorrecto = RegistrarDatos("N00101920", "Marta", "constancia", "Descargar constancia de asistencia");

	if (esCorrecto)
    {
		Console.WriteLine("Datos ingresados exitosamente.");
    }


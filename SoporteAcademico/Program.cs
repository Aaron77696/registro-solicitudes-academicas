
    bool ValidarCodigo(string codigo, int longitudMin)
    {
        return true;
    }

    bool ValidarTipoConsulta(string tipoconsulta)
    {
        return true;
    }
    
    bool RegistrarDatos(string codigo, string nombre, string tipoconsulta, string descripcionbreve, int longitudMin)
    {
        bool codValido = ValidarCodigo(codigo, longitudMin);
        bool tipoValido = ValidarTipoConsulta(tipoconsulta);
        return codValido && tipoValido;
    }


    bool esCorrecto = RegistrarDatos("N00101920", "Marta", "constancia", "Descargar constancia de asistencia", 8);

	if (esCorrecto)
    {
		Console.WriteLine("Datos ingresados exitosamente.");
    }


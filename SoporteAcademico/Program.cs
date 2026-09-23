 using System;
 // Se usan parámetros para enviar datos a las funciones sin depender de variables globales innecesarias.

// Se controla el alcance de variables diferenciando en datos del programa principal y datos internos de cada función.

static void EjecutarPruebas()
{
    List<string> resultados = new List<string>();

    // PRUEBA 1 - Datos válidos
    bool prueba1 = RegistrarDatos("N00101920", "Marta", "constancia", "Descargar constancia");
    resultados.Add("Prueba 1 (datos válidos): " + prueba1);

    // PRUEBA 2 - Datos vacíos
    bool prueba2 = RegistrarDatos("", "Marta", "constancia", "Descargar constancia");
    resultados.Add("Prueba 2 (código vacío): " + prueba2);

    // PRUEBA 3 - Tipo de consulta incorrecto
    bool prueba3 = RegistrarDatos("N00101920", "Marta", "reclamo", "Descargar constancia");
    resultados.Add("Prueba 3 (tipo incorrecto): " + prueba3);

    // PRUEBA 4 - Prioridad alta
    string prueba4 = AsignarPrioridadConsulta("pagos");
    resultados.Add("Prueba 4 (prioridad alta): " + prueba4);

    // PRUEBA 5 - Prioridad baja
    string prueba5 = AsignarPrioridadConsulta("deportes");
    resultados.Add("Prueba 5 (prioridad baja): " + prueba5);

    Console.WriteLine("----- RESULTADOS DE PRUEBAS -----");
    foreach (string resultado in resultados)
    {
        Console.WriteLine(resultado);
    }
}

EjecutarPruebas();


int contador = 0;

        MostrarMenuPrincipal();

        while (contador < 3)
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine()!;

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Tipo de consulta: ");
            string tipoconsulta = Console.ReadLine()!;

            Console.Write("Descripción: ");
            string descripcionbreve = Console.ReadLine()!;

            bool esCorrecto = RegistrarDatos(codigo, nombre, tipoconsulta, descripcionbreve);

            if (esCorrecto)
            {
                string prioridad = AsignarPrioridadConsulta(tipoconsulta);
                MostrarResumen(codigo, nombre, tipoconsulta, descripcionbreve, prioridad);
                contador = contador + 1;
            }
            else
            {
                Console.WriteLine("Datos inválidos, intente nuevamente.");
            }
        }




    static void MostrarMenuPrincipal()
    {
        Console.WriteLine("===== MENÚ PRINCIPAL =====");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Ver resumen");
        Console.WriteLine("3. Salir");
    }
    
    static void MostrarResumen(string codigo, string nombre, string tipoconsulta,
                            string descripcionbreve, string prioridad)
    {
        Console.WriteLine("----- RESUMEN DE SOLICITUD -----");
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Tipo de consulta: " + tipoconsulta);
        Console.WriteLine("Descripción: " + descripcionbreve);
        Console.WriteLine("Prioridad: " + prioridad);
    }

    static string AsignarPrioridadConsulta(string tipoconsulta)
    {
        string prioridad = "Baja";

        if (tipoconsulta == "pagos") { prioridad = "Alta"; }
        if (tipoconsulta == "matricula") { prioridad = "Alta"; }
        if (tipoconsulta == "constancia") { prioridad = "Media"; }
        if (tipoconsulta == "plataforma") { prioridad = "Media"; }
        if (tipoconsulta == "otro") { prioridad = "Baja"; }

        return prioridad;
    }

    static bool ValidarCodigo(string codigo, int longitudMin)
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

    static bool ValidarTextoObligatorio(string texto)
    {
        bool esValido2 = (texto != "");
        return esValido2;
    }



    static bool ValidarTipoConsulta(string tipoconsulta)
    {
  	bool esValido1 = false;	
	if (tipoconsulta == "matricula") 
    {
	esValido1 = true;
    }
	if (tipoconsulta == "pagos") 
    {
	esValido1 = true;       
    }
    if (tipoconsulta == "constancia") 
	{
    	esValido1 = true;
    }
	if (tipoconsulta == "plataforma") 
	{
    	esValido1 = true;
    }
	if (tipoconsulta == "otro")
    {
		esValido1 = true;
    }
    return esValido1;
    }
    
    static bool RegistrarDatos(string codigo, string nombre, string tipoconsulta, string descripcionbreve)
    {
        int longitudMin = 8;
        
    bool codValido = ValidarCodigo(codigo, longitudMin);
    bool tipoValido = ValidarTipoConsulta(tipoconsulta);
    bool nombreValido = ValidarTextoObligatorio(nombre);
    bool descripcionValida = ValidarTextoObligatorio(descripcionbreve);

    bool esBoleano1 = codValido && tipoValido && nombreValido && descripcionValida;
    return esBoleano1;
    }
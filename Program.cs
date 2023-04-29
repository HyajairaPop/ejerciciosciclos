// DECLARAR VARIABLES

String NombreUsuarioGuardado;
string contraseñaUsuarioGuardado;
string NombreUsusario;
string contraseñaUsuario;
int intentos = 0;
bool sesionOk = false;

// PEDIMOS AL USUARIO INGRESAR DATOS 
Console.WriteLine("****** Nueva Cuenta de Usuario ******");
Console.Write("Ingrese su usuario");
NombreUsuarioGuardado = Console.ReadLine();
Console.Write("Ingrese su contraseña");
contraseñaUsuarioGuardado = Console.ReadLine();
Console.WriteLine("****** Su Cuenta ha sido Creada Correctamente ******");

//AHORA VAMOS A SIMULAR EL INICIO DE SESION

do
{
    Console.WriteLine("***** BIENVENIDO AL PORTAL WEB ******");
    Console.WriteLine("Ingrese su usuario");
    NombreUsusario = Console.ReadLine();
    Console.Write("Escriba contraseña: ");
    contraseñaUsuario = Console.ReadLine();

    if (NombreUsusario.Equals(NombreUsuarioGuardado) && contraseñaUsuario.Equals(contraseñaUsuarioGuardado))
    {
        sesionOk = true;
        Console.WriteLine("Sesion iniciada correctamente");
    }
    else
    {
        intentos++;
        Console.WriteLine("Usuario y contraseña incorrecta, vuelva a intentarlo");
    }

} while (!sesionOk && intentos < 3);
if(sesionOk)
{
    Console.WriteLine("BIENVENIDO AL SISTEMA!!");
}else
{
    if (intentos >= 3)
    {
        Console.WriteLine("Haz realizado más de 3 intentos, intentalo más tarde");
    }
}
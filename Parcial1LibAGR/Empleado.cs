namespace Parcial1LibAGR
{
    public abstract class Empleado
    {
        public abstract string nombre { get; set; }
        public abstract int salarioBase { get; set; }

        public void obtenerInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Salario Base: {salarioBase}");
        }

        public  int calcularSalarioTotal()
        {
            Console.WriteLine($"Salario total de {nombre}...es: {salarioBase * 12}");
        }
    }
}

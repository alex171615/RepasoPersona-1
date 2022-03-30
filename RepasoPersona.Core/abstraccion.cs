namespace RepasoPersona.Core
{
    public class abstraccion
    {
        class Persona:Cuenta
        {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public double Efectivo { get; private set; }
        public double Saldo {get;private set;}
        }
        

        
    }
}
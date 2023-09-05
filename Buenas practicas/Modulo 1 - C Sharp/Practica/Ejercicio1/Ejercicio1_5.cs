namespace Modulo1.Ejercicio1
{
    public class MetodoPago
    {
        public const string TARJETA_CREDITO = "CREDITO";
        public const string CONTADO = "CONTADO";
        // Segun el caso es correcto
        // Ahora bien, si hay muchos modos de pago deberían estar en una tabla en BBDD
        // Si es solo para el algoritmo y son estos dos, en constantes está bien
        // Quizá sería mejor utilizar un ENUM
        // Si no va a usarse desde fuera de la clase debería declararse como private
    }
}
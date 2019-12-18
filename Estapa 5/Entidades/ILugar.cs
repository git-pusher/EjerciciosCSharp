namespace CoreEscuela.Entidades
{
    public interface ILugar
    {
        //No hacen uso de los modificadores, todos los accesos deben ser públicos
        string Direccion { get; set; }

        void LimpiarLugar();
}
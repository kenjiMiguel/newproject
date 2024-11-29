namespace ProyectoNew.Models
{
    public class puntoVenta
    {
        public int id_tarjeta { get; set; }
        public string numero { get; set; }    
        public string vencimiento { get; set; } 
        public int CVC { get;   set; }
        public string banco { get; set; }
        public int id_usuario { get; set; }

    }
}

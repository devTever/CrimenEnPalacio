namespace CrimenEnPalacio
{
    // Clase Sala
    class Sala
    {
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public Objeto Objeto { get; set; }
        public Personaje Personaje { get; set; }
        public List<string> Salidas { get; set; } = new List<string>();
    }
}

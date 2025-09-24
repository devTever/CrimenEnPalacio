namespace CrimenEnPalacio
{
    // Clase Personaje
    class Personaje
    {
        public string Nombre { get; set; } = string.Empty;
        public string Dialogo { get; set; } = string.Empty;
        public bool Muerto { get; set; } = false;
        public bool Culpable { get; set; } = false;
    }
}

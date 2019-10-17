using GranColo.BusinessLayer.Entities;

namespace GranColo.BusinessLayer.Entities
{
    public class DirectorTecnico
    {
        private TipoDocumento tipoDocumento;

        public int IdDirectorTecnico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroDoc { get; set; }
        public int TipoDoc { get; set; }
        public string NombreUsuario { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
        public Club Club { get; set; }

        public DirectorTecnico()
        {
            tipoDocumento = new TipoDocumento();
        }

        public TipoDocumento GetTipoDocumento()
        {
            return tipoDocumento;
        }
        public void SetTipoDocumento(TipoDocumento tipoDocumento)
        {
            this.tipoDocumento = tipoDocumento;
        }

    }
}

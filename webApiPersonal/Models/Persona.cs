namespace webApiPersonal.Models
{
    public class Persona
    {
        public long Id { get; set; }
        public long Legajo {  get; set; }
        public DateTime FechaAlta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public long Cuil { get; set; }
        public long Telefono { get; set;}
        public string Email { get; set; }
        public string Genero { get; set; }
        public string ObraSocial { get; set; }
        public string EstadoCivil { get; set; }
        public int fkReloj {  get; set; }
        public int fkTipoHorario { get; set; }
        public int fkGrupo { get; set; }
        public int fkArea { get; set; }
        public int fkCategoria { get; set; }
        public bool noche { get; set; }
        public bool extras { get; set; }
        public DateTime FechaBaja{ get; set; }
        public bool baja { get; set; }




    }
}

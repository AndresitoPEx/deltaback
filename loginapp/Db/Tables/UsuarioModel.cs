using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginapp.Db.Tables
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [Key]
        [Column("idusuario")]
        public int Id { get; set; }
        [Column("nombres")]
        public string nombre { get; set; }
        [Column("apellidos")]
        public string apellidos { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("contrasena")]
        public string clave { get; set; }
        [Column("idrol")]
        public int rol { get; set; }
        [Column("usuario")]
        public string usuario { get; set; }
    }
}

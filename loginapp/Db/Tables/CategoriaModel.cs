using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginapp.Db.Tables
{
    [Table("categoria")]
    public class CategoriaModel
    {
        [Key]
        [Column("idcategoria")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}

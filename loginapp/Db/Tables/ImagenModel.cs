using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loginapp.Db.Tables
{
    [Table("imagen")]
    public class ImagenModel
    {
        [Key]
        [Column("idimagen")]
        public int Id { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}

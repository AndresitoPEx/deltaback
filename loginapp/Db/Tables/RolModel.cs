using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace loginapp.Db.Tables
{
        [Table("rol")]
        public class RolModel
        {
            [Key]
            [Column("idrol")]
            public int Id { get; set; }
            [Column("rol")]
            public string nombre { get; set; }
        }
}

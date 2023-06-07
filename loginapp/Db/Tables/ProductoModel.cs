using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace loginapp.Db.Tables
{
    
    
        [Table("producto")]
        public class ProductoModel
        {
            [Key]
            [Column("idproducto")]
            public int Id { get; set; }
            [Column("nombre")]
            public string Nombre { get; set; }
            [Column("idcategoria")]
            public int categoria { get; set; }
            [Column("codigo")]
            public string codigo { get; set; }
            [Column("modelo")]
            public string modelo { get; set; }
            [Column("color")]
            public string color { get; set; }
            [Column("descripcion")]
            public string descripcion { get; set; }
            [Column("precio")]
            public decimal precio { get; set; }
            [Column("imagen")]
            public int imagen { get; set; }
        }
    
}

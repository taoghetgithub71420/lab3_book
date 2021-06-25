namespace lab3_book.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]


        [Required(ErrorMessage = "ID not null ")]
        public int ID { get; set; }




        [Required(ErrorMessage = "Title not null ")]
        [StringLength(100, ErrorMessage = "Title < 100 character")]
        public string Title { get; set; }




        [Required(ErrorMessage = "Des not null ")]
        [StringLength(255)]
        public string Des { get; set; }



        [StringLength(30, ErrorMessage = "Author < 30 character")]
        [Required(ErrorMessage = "Author not null ")]
        public string Author { get; set; }



    
        [StringLength(255)]
        [Required(ErrorMessage = "Image not null ")]
        public string Images { get; set; }




        [Required(ErrorMessage = "Price not null ")]
        [Range(1000, 1000000, ErrorMessage = "Price 1000 to 10000000 " )]
        public int? Price { get; set; }
    }
}

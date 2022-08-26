namespace MusicHub.Data.Models
{
    using MusicHub.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    

    public class Producer
    {
        //• Id – integer, Primary Key
        [Key]
        public int Id { get; set; }

        //•	Name – text with max length 30 (required)

        [Required]
        [MaxLength(GlobalConstants.ProducerNameMaxLength)]
        public string Name { get; set; }

        //•	Pseudonym – text
        public string Pseudonym { get; set; }

        //•	PhoneNumber – text
        public string PhoneNumber { get; set; }

        //TODO
        //•	Albums – a collection of type Album

    }
}

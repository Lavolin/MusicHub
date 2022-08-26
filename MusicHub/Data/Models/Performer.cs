namespace MusicHub.Data.Models
{
    using MusicHub.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class Performer
    {
        //        •	Id – integer, Primary Key
        [Key]
        public int Id { get; set; }

        //•	FirstName – text with max length 20 (required) 
        [Required]
        [MaxLength(GlobalConstants.PerformerNameMaxLength)]
        public string FirstName { get; set; }

        //•	LastName – text with max length 20 (required) 
        [Required]
        [MaxLength(GlobalConstants.PerformerNameMaxLength)]
        public string LastName { get; set; }

        //•	Age – integer(required)
        [Required]
        public int Age { get; set; }

        //•	NetWorth – decimal (required)
        [Required]
        public decimal NetWorth { get; set; }

        //•	PerformerSongs – a collection of type SongPerformer
       // public ICollection< MyProperty { get; set; }

    }
}

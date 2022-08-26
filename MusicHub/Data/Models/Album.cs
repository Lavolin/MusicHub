namespace MusicHub.Data.Models
{
    using MusicHub.Common;

    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }

        
        [Key]
        public int Id { get; set; }

        
        [Required]
        [MaxLength(GlobalConstants.AlbulNameMaxLength)]
        public string Name { get; set; }

       
        [Required] // datetime is not null, so can be skipped
        public DateTime ReleaseDate { get; set; }


        //•	Price – calculated property(the sum of all song prices in the album) - not in the Db!!!
        [NotMapped]  // EF will not create this property in Db
        public decimal Price 
            => this.Songs.Any() 
            ? this.Songs.Sum(s => s.Price) 
            : 0m;

        [ForeignKey(nameof(Producer))]
        public int? ProducerId { get; set; }
        public virtual Producer Producer { get; set; }


        
        public virtual ICollection<Song> Songs { get; set; }

    }
}

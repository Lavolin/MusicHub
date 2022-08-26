namespace MusicHub.Data.Models
{
    using MusicHub.Common;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Album
    {
        public Album()
        {
            this.Songs = new HashSet<Song>();
        }

        // • Id – integer, Primary Key
        [Key]
        public int Id { get; set; }

        //•	Name – text with max length 40 (required)
        [Required]
        [MaxLength(GlobalConstants.AlbulNameMaxLength)]
        public string Name { get; set; }

        //•	ReleaseDate – date(required)
        [Required] // datetime is not null, so can be skipped
        public DateTime ReleaseDate { get; set; }

        //TODO
        //•	Price – calculated property(the sum of all song prices in the album) - not in the Db!!!


        //•	ProducerId – integer, foreign key
        public int? ProducerId { get; set; }

        //•	Producer – the album's producer
        //public string Producer { get; set; }

        //TODO
        //•	Songs – a collection of all Songs in the Album
        public ICollection<Song> Songs { get; set; }

    }
}

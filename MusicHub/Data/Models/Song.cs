namespace MusicHub.Data.Models
{
    using MusicHub.Common;
    using MusicHub.Data.Models.Enums;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Song
    {
         
           
        

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(GlobalConstants.SongNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public Genre Genre { get; set; }

        //•	AlbumId – integer, foreign key
        //TODO
        public int? AlbumId { get; set; }

        //TODO
        //•	Album – the song's album - collection
        public string Album { get; set; }

        //•	WriterId – integer, Foreign key(required)
        //TODO
        [Required]
        public int WriterId { get; set; }


        //•	Writer – the song's writer
        public string Writer { get; set; }

        //•	Price – decimal (required)
        [Required]
        public decimal Price { get; set; }

        //TODO
        //•	SongPerformers – a collection of type SongPerformer
        public string SongPerformers { get; set; }


    }
}

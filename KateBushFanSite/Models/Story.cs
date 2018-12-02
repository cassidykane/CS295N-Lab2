﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KateBushFanSite.Models
{
    /// <summary>
    /// Properties for submitted stories
    /// </summary>
    public class Story
    {
        private List<Comment> comments = new List<Comment>();
        private List<Rating> ratings = new List<Rating>();

        public int StoryID { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter a Date")]
        public DateTime Date { get; set; }

        [StringLength(400, MinimumLength = 20)]
        [Required(ErrorMessage = "Please enter a Story")]
        public string StoryText { get; set; }

        public double AverageRating
        {
            get
            {
                List<int> ratingNumbers = new List<int>();
                foreach (Rating r in Ratings)
                    ratingNumbers.Add(r.RatingNumber);
                return ratingNumbers.Average();
            }
        }

        public ICollection<Comment> Comments { get { return comments; } }
        public ICollection<Rating> Ratings { get { return ratings; } }
    }
}

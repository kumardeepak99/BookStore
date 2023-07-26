﻿namespace BookStore.Domain.Models
{
    public class Book
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int PublicationYear { get; set; }
    }
}

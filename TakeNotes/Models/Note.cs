﻿namespace TakeNotesServer.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string NoteContent { get; set; }
        public int UserId { get; set; }
    }
}

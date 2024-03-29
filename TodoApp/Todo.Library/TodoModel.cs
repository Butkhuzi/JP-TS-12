﻿using TodoApp.Library;

namespace Todo.Library
{
    public class TodoModel
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public int UserId { get; set; }

        public override bool Equals(object obj)
        {
            return new TodoEquilityComparer().Equals(obj);
        }
        public override int GetHashCode()
        {
            return new TodoEquilityComparer().GetHashCode();
        }
        public override string ToString()
        {
            return Title;
        }
    }
}

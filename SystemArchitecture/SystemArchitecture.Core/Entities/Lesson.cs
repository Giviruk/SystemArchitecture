using System;
using Force.Ddd;

namespace SystemArchitecture.Core.Entities
{
    public class Lesson : HasIdBase<int>
    {
        public User Teacher { get; protected set; }

        public User Student { get; protected set; }
        
        public DateTime StartDate { get; protected set; }
        
        public DateTime EndDate { get; protected set; }

        public string Title { get; protected set; }

        protected Lesson()
        {
        }

        public Lesson(User teacher,User student,DateTime startDate, DateTime endDate, string title)
        {
            Teacher = teacher;
            Student = student;
            StartDate = startDate;
            EndDate = endDate;
            Title = title;
        }
    }
}
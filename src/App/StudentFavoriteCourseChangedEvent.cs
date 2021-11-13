namespace App
{
    public sealed class StudentFavoriteCourseChangedEvent : IDomainEvent
    {
        public long StudentId { get; }
        public Course NewFav { get; }

        public StudentFavoriteCourseChangedEvent(long studentId, Course newFav)
        {
            StudentId = studentId;
            NewFav = newFav;
        }
    }
}
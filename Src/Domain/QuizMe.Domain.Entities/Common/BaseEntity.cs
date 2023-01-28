namespace QuizMe.Domain.Entities.Common
{
    public class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get ; set ; }
    }
}

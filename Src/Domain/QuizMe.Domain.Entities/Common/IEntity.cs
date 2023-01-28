using System.ComponentModel.DataAnnotations.Schema;

namespace QuizMe.Domain.Entities.Common
{
    public interface IEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        TKey Id { get; set; }
    }
}

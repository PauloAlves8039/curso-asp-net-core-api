using System;
using System.ComponentModel.DataAnnotations;

namespace src.Api.Domain.Entities
{
    /// <summary>
    /// Classe responsável por representar uma entidade base.
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

    }
}

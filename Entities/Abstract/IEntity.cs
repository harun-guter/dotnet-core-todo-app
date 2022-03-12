using System;

namespace Entities.Abstract
{
    public interface IEntity
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
    }
}

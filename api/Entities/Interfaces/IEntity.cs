using System;

namespace Entities.Interfaces;
public interface IEntity
{
    public string Id { get; set; }
    public DateTime Date { get; set; }
}
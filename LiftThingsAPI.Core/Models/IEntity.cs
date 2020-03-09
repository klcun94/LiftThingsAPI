using System;
namespace LiftThingsAPI.Core.Models
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}

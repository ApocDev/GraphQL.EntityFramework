using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("entity2")]
public class Entity2
{
    public Guid Id { get; set; } = SimpleSequentialGuid.NewGuid();
    public string Property { get; set; }
}
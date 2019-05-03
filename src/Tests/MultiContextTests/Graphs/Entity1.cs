using System;
using System.ComponentModel.DataAnnotations.Schema;


[Table("entity1")]
public class Entity1
{
    public Guid Id { get; set; } = SimpleSequentialGuid.NewGuid();
    public string Property { get; set; }
}
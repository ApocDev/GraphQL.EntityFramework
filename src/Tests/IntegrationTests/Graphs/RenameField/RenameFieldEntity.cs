using System;
using System.Collections.Generic;

public class RenameFieldEntity
{
    public Guid Id { get; set; }
    public ChildForRenameEntity Child { get; set; }
    public IList<ChildForRenameEntity> Children { get; set; }
}
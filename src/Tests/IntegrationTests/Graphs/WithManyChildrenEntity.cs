﻿using System;

public class WithManyChildrenEntity
{
    public Guid Id { get; set; } = SimpleSequentialGuid.NewGuid();
    public Child1Entity Child1 { get; set; }
    public Child2Entity Child2 { get; set; }
}
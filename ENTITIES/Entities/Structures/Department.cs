﻿using ENTITIES.Entities.Generic;

namespace ENTITIES.Entities.Structures;

public class Department : Auditable, IEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}

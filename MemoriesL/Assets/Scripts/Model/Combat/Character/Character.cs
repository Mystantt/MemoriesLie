using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Character
{
    public string Name { get; }

    public string ID { get; }

    public string Description { get; }

    public Character(string name,string description)
    {
        Name = name;
        Description = description;
        ID = Guid.NewGuid().ToString();
    }
}

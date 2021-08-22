using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Spell
{
    public string Name { get; }

    public string Description { get; }

    public string ID { get; }
    /*
    private int _level;
    public int LVL {
        get => _level;
    }*/

    public SpellElement Element { get; }
    public Spell(string name, string description, SpellElement spellElement)
    {
        Name = name;
        Description = description;
        ID = Guid.NewGuid().ToString();
        //_level = 1;
        Element = spellElement;
    }
}

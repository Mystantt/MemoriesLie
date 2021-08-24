using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hero : FC
{
    protected Hero(string name, string dsc, int hp, int energy, List<Spell> sp) : base(name, dsc, hp, energy, sp)
    {
        Level = new Level();
    }

    public Level Level { get; set; }
}

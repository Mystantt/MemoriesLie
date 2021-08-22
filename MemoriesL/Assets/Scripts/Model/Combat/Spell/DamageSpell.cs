using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpell : ActiveSpell
{
    public DamageSpell(string name, string dsc, SpellElement sp, int cost, int cd, TargetMode tmod, int dmg) : base(name, dsc, sp, cost, cd, tmod)
    {
        if(dmg > 0)
        {
            Damages = dmg;
        }
        else
        {
            throw new System.ArgumentException("Damages can't be null or negative");
        }
    }

    public int Damages { get; }
}

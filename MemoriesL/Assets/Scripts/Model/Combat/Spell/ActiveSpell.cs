using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSpell : Spell
{
    public int Cost { get; }

    public int CD { get; }

    public TargetMode Target { get; }

    public ActiveSpell(string name,string dsc,SpellElement sp, int cost,int cd, TargetMode tmod) : base(name, dsc, sp)
    {
        if(cost > 0 && CD > 0)
        {
            Cost = cost;
            CD = cd;
            Target = tmod;
        }
        else
        {
            throw new System.ArgumentException("The cost and the cooldown of an active spell must be strictly positive and not null");
        }
    }
}

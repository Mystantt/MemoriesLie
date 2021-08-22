using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSpell : ActiveSpell
{
    public HealSpell(string name, string dsc, SpellElement sp, int cost, int cd, TargetMode tmod, int regen) : base(name, dsc, sp, cost, cd, tmod)
    {
        if(regen > 0)
        {
            Regen = regen;
        }else
        {
            throw new System.ArgumentException("The amount of healing must be strictly positive");
        }
    }

    public int Regen { get; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebolt : DamageSpell
{
    public Firebolt() : base("Firebolt", "A small ball of fire", SpellElement.FIRE, 10, 2, TargetMode.MONO,25)
    {
    }
}

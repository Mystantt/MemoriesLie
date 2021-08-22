using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : DamageSpell
{
    public Slash() : base("Slash", "The user slashes all his opponent in a cool way", SpellElement.PHYSICAL, 30, 5, TargetMode.MULTIPLE, 80)
    {
    }
}

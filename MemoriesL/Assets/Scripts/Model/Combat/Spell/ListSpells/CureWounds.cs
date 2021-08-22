using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CureWounds : HealSpell
{
   public CureWounds() : base("Cure Wounds","You channel one prayer to heal yourself", SpellElement.LIGHT, 20, 4, TargetMode.SELF, 60) { }
}

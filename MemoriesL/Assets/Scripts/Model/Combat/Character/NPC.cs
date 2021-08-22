using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public List<string> Dialogues { get; }

    public NPC(string name,string description,List<string> dialogues) : base(name, description)
    {
        Dialogues = dialogues;
    }
}

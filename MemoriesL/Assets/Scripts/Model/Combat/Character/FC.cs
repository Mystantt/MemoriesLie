using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FC : Character
{
    public int MAXHP { get; }

    private int _hp;
    public int CurrentHP
    {
        get => _hp;
        set
        {
            if (value + _hp > MAXHP)
            {
                _hp = MAXHP;
            }
            else if (value + _hp < 0)
            {
                _hp = 0;
            }
            else
            {
                _hp += value;
            }
        }
    }

    public int MAXEN { get; }

    private int _energy;
    public int CurrentEN
    {
        get => _energy;
        set
        {
            if (value + _energy > MAXEN)
            {
                _energy = MAXEN;
            }
            else if (value + _energy < 0)
            {
                _energy = 0;
            }
            else
            {
                _energy += value;
            }
        }
    }

    private List<Spell> _spells;
    public List<Spell> Spells { get => new List<Spell>(_spells); }

    public FC(string name,string dsc,int hp,int energy,List<Spell> sp) : base(name, dsc)
    {
        if(hp > 0 && energy > 0)
        {
            MAXHP = hp;
            _hp = hp;
            MAXEN = energy;
            _energy = energy;
            _spells = new List<Spell>(sp);
        }
        else
        {
            throw new System.ArgumentException("The health and energy of any FC can't be null or negative");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats 
{
    private int _strength = 0;
    private int _constitution = 0;
    private int _charisma = 0;
    private int _wisdom = 0;
    private int _intel = 0;

    public int Strength { get => _strength;
            set
        {
            if(value+_strength > 200)
            {
                _strength = 200;
            }else if(value + _strength < 0)
            {
                _strength = 0;
            }
            else
            {
                _strength += value;
            }
        }
    }
    public int Constitution
    {
        get => _constitution;
        set
        {
            if (value + _constitution > 200)
            {
                _constitution = 200;
            }
            else if (value + _constitution < 0)
            {
                _constitution = 0;
            }
            else
            {
                _constitution += value;
            }
        }
    }
    public int Charisma
    {
        get => _charisma;
        set
        {
            if (value + _charisma > 200)
            {
                _charisma = 200;
            }
            else if (value + _charisma < 0)
            {
                _charisma = 0;
            }
            else
            {
                _charisma += value;
            }
        }
    }
    public int Intel
    {
        get => _intel;
        set
        {
            if (value + _intel > 200)
            {
                _intel = 200;
            }
            else if (value + _intel < 0)
            {
                _intel = 0;
            }
            else
            {
                _intel += value;
            }
        }
    }
    public int Wisdom
    {
        get => _wisdom;
        set
        {
            if (value + _wisdom > 200)
            {
                _wisdom = 200;
            }
            else if (value + _wisdom < 0)
            {
                _wisdom = 0;
            }
            else
            {
                _wisdom += value;
            }
        }
    }

    public Stats()
    {
        Strength = 0;
        Constitution = 0;
        Charisma = 0;
        Intel = 0;
        Wisdom = 0;
    }

    public int getModStrength()
    {
        return Strength / 2;
    }
    public int getModCharisma()
    {
        return Charisma / 2;
    }
    public int getModIntel()
    {
        return Intel / 2;
    }
    public int getModWisdom()
    {
        return Wisdom / 2;
    }
    public int getModConstitution()
    {
        return Constitution / 2;
    }
}

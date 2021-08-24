using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    private int _exp;

    private int _level;

    public int LVL { get => _level; }

    public int EXP { get => _exp;
        set
        {
            if(value+_exp > 1000000){
                _exp = 1000000;
                _level = 20;
            }else if(value+_exp < 0)
            {
                _level = 1;
                _exp = 0;
            }
            else
            {
                
                _exp += value;
                _level = _exp / 50000;
            }
        }
    }
}

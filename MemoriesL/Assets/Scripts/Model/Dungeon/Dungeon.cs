using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Dungeon's class which represents every Dungeon in which the player will play
 * Author : DOMPEY Fabien
 * Date : 16/08/2021
 */
public class Dungeon
{
    private Difficulty Difficulty { get; }

    private List<DungeonStage> Stages { get;  }

    private int CompletionRate { get; set; }

    public Dungeon(Difficulty d)
    {
        int numberofStages = 1;
        Difficulty = d;
        switch (d)
        {
            case Difficulty.Easy:
                numberofStages = 2;
                break;
            case Difficulty.Medium:
                numberofStages = 4;
                break;
            case Difficulty.Hard:
                numberofStages = 8;
                break;
            case Difficulty.VeryHard:
                numberofStages = 16;
                break;
        }
        CompletionRate = 0;
        Stages = new List<DungeonStage>(Algo.GenerateStages(numberofStages));
    }


}

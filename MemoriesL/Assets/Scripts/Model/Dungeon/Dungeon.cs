using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Dungeon's class which represents every Dungeon in which the player will play
 * Author : DOMPEY Fabien
 * Date : 16/08/2021
 */
public class Dungeon
{
    public int NumberOfFloors { get; }

    public int CurrentLevel { get; }

    public DungeonFloor CurrentFloor { get; set; }

    public Difficulty Difficulty { get; }

    public List<DungeonStage> Stages { get;  }

    public int CompletionRate { get; set; }

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
        Stages = new List<DungeonStage>(GenerationAlgo.GenerateStages(numberofStages));
        NumberOfFloors = numberofStages * Stages[0].NumberOfFloorsPerStage;
        CurrentFloor = Stages[0].Floors[0];
        CurrentLevel = 1;
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Algo
{
    //done
    internal static List<DungeonStage> GenerateStages(int numberofStages)
    {
        List<DungeonStage> result = new List<DungeonStage>();
        Dimension d = Dimension.Null;
        for(int i = 0; i < numberofStages; i++)
        {
            if (i > 1)
            {
                d = result[i - 1].Dimension;
            }
                result.Add(Algo.GenerateStage(d));
     
        }
        return result;
    }

    internal static IEnumerable<DungeonFloor> GenerateFloors(int stage)
    {
        throw new NotImplementedException();
    }

    internal static DungeonStage GenerateStage(Dimension dim)
    {
        DungeonStage ds = null;
        return ds;
    }

    //done
    public static Dungeon GetDungeon(Difficulty d)
    {
        Dungeon dungeon = new Dungeon(d);
        return dungeon;
    }
}

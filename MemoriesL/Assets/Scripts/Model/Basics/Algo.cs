using System;
using System.Collections;
using System.Collections.Generic;

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

    //done
    internal static IEnumerable<DungeonFloor> GenerateFloors(int stage)
    {
        List<DungeonFloor> floors = new List<DungeonFloor>();
        floors.Add(GenerateFloor(TypeRoom.Safe));
        for(int i = 1; i < stage - 1; i++)
        {
            floors.Add(GenerateFloor(TypeRoom.Dangerous));
        }
        floors.Add(GenerateFloor(TypeRoom.Boss));
        return floors;
    }

    private static DungeonFloor GenerateFloor(TypeRoom safe)
    {
        DungeonFloor df = null;
        switch (safe)
        {
            case TypeRoom.Safe:
                break;
            case TypeRoom.Dangerous:
                break;
            case TypeRoom.Boss:
                break;
        }
        return df;
    }

    //done
    internal static DungeonStage GenerateStage(Dimension dim)
    {
        DungeonStage ds = null;
        Random rnd = new Random();
        int d = rnd.Next(1, 9);
        Dimension dimension = GetDimensionFromIndex(d);
        while (dimension.Equals(dim))
        {
            d = rnd.Next(1, 9);
            dimension = GetDimensionFromIndex(d);
        }
        ds = new DungeonStage(dimension);
        return ds;
    }

    private static Dimension GetDimensionFromIndex(int i)
    {
        Dimension d = Dimension.Null;
        switch (i)
        {
            case 1:
                d = Dimension.Cave;
                break;
            case 2:
                d = Dimension.Cemetery;
                break;
            case 3:
                d = Dimension.Deep;
                break;
            case 4:
                d = Dimension.Desert;
                break;
            case 5:
                d = Dimension.Forest;
                break;
            case 6:
                d = Dimension.Hell;
                break;
            case 7:
                d = Dimension.Labyrinth;
                break;
            case 8:
                d = Dimension.Mountain;
                break;
            case 9:
                d = Dimension.Swamp;
                break;

        }
        return d;
    }

    //done
    public static Dungeon GetDungeon(Difficulty d)
    {
        Dungeon dungeon = new Dungeon(d);
        return dungeon;
    }
}

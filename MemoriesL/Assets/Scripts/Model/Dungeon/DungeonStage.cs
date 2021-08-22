using System.Collections.Generic;

public class DungeonStage
{
    public Dimension Dimension { get; }

    public List<DungeonFloor> Floors { get; }

    public int NumberOfFloorsPerStage { get; }
    public DungeonStage(Dimension d)
    {

        NumberOfFloorsPerStage = 5;
        Floors = new List<DungeonFloor>(GenerationAlgo.GenerateFloors(NumberOfFloorsPerStage));
        Dimension = d;
    }
}
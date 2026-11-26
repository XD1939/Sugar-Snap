using System;
using System.IO;

namespace Scripts.Game;

public class LevelFileParser()
{
    private readonly string Delimiter = ",";
    private readonly string DirectionDelimiter = ".";
    private readonly int NameIdx = 0;
    private readonly int WidthIdx = 1;
    private readonly int HeightIdx = 2;
    private readonly int FogOfWarIdx = 3;
    private readonly int SpacerRow = 1;
    public static string[] ParseLevelFile(string levelFilePath)
    {
        return File.ReadAllLines(levelFilePath);
    }

    public string GetLevelName(string[] levelFile)
    {
        string[] headerParts = levelFile[0].Split(Delimiter);
        return headerParts[NameIdx];
    }

    public int GetLevelWidth(string[] levelFile)
    {
        string[] headerParts = levelFile[0].Split(Delimiter);
        return int.Parse(headerParts[WidthIdx]);
    }

    public int GetLevelHeight(string[] levelFile)
    {
        string[] headerParts = levelFile[0].Split(Delimiter);
        return int.Parse(headerParts[HeightIdx]);
    }

    public bool GetFogOfWar(string[] levelFile)
    {
        string[] headerParts = levelFile[0].Split(Delimiter);
        string fogOfWarIndicator = headerParts[FogOfWarIdx];
        return fogOfWarIndicator.Equals("Dark");
    }

    
    

   
}

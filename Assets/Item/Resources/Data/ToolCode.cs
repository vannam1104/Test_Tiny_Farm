using System;
using UnityEngine;

public enum ToolCode
{
    NoItem,
    Hoe = 10, // Cuoc
    Can = 11, // Binh nuoc
    Sword = 12, // Kiem
    Bow = 13 // Cung
}

public class ToolCodeParser
{
    public static ToolCode FromString(string toolName)
    {
        try
        {
            return (ToolCode)System.Enum.Parse(typeof(ToolCode), toolName);
        }
        catch (ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return ToolCode.NoItem;
        }
    }
}

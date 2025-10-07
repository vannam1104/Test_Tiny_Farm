using System;
using UnityEngine;

public enum ItemCode
{
    NoItem = 0,

    // Crop
    Item_Dau = 100,
    Item_Potato = 101,

    // Seeds
    Seed_Dau = 200,
    Seed_Potato = 201,
    
    // Tools
    Tool_Hoe = 300,
    Tool_WaterCan = 301,
    Tool_Sword = 302,
    Tool_Bow = 303,


}

public class ItemCodeParser
{
    public static ItemCode FromString(string itemName)
    {
        try
        {
            return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
        }
        catch (ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return ItemCode.NoItem;
        }
    }
}

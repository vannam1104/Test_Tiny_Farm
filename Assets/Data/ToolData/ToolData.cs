using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tool", menuName = "Data/Item/ToolData")]
public class ToolData : ItemData
{
    public ToolCode toolCode = ToolCode.NoItem;
    public ToolType toolType = ToolType.NoType;
    public int durability = 100; //Do ben
    public float efficiency = 1f; // suc manh
}

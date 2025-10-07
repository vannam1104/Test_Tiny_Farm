using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : GameBehaviour
{
    [SerializeField] protected int maxSlot = 999;
    [SerializeField] protected List<ItemInventory> items;
    public List<ItemInventory> Items => items;

    protected override void Start()
    {
        base.Start();
    }

    public virtual bool AddItem(ItemInventory itemInventory)
    {
        int addCount = itemInventory.itemCount;
        ItemData itemData = itemInventory.itemData;
        ItemCode itemCode = itemData.itemCode;
        ItemType itemType = itemData.itemType;

        if (itemType == ItemType.Crop) return this.AddEquipment(itemInventory);
        return this.AddItem(itemCode, addCount);
    }

    public virtual bool AddEquipment(ItemInventory itemInventory)
    {
        return true;
    }

    public virtual bool AddItem(ItemCode itemCode, int addCount)
    {
        return true;
    }
}

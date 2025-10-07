using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Data/Item/ItemData")]
public class ItemData : ScriptableObject
{
    public ItemCode itemCode = ItemCode.NoItem;
    public ItemType itemType = ItemType.NoType;
    public string itemName = "no-name";
    public Sprite icon;
    public int defaultMaxStack = 999;

    public static ItemData FindByItemCode(ItemCode itemCode)
    {
        var profiles = Resources.LoadAll("Data", typeof(ItemData));
        foreach (ItemData profile in profiles)
        {
            if (profile.itemCode != itemCode) continue;
            return profile;
        }
        return null;
    }
}

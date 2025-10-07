using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Seed", menuName = "Data/Item/SeedData")]
public class SeedData : ItemData
{
    public CropData cropToGrow; // Loai cay
    public int cost; //Gia mua
    public int quantityOnUse = 1; //So luong hat bi tru khi trong
    public Sprite seedSprite; // Hinh hat giong
}

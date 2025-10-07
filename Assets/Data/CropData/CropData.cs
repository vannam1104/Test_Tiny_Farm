using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Crop", menuName = "Data/Item/CropData")]
public class CropData : ScriptableObject
{
    [Header("Thông tin cơ bản")]
    public string CropName;
    public Sprite[] growthSprites; // từng giai đoạn phát triển
    public float[] growthTimes; // thời gian giữa các giai đoạn

    [Header("Thu hoạch")]
    public int harvestYield = 1; // So luong thu hoach
    public ItemData harvestItem; //Item thu duoc khi thu hoach
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSO : ScriptableObject
{
    public int id;
    public string displayName;
    public Sprite icon;
    public int price;
    public ItemType itemType;
    public bool isStackable;
}
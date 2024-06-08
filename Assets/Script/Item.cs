using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemList
{
    Armor,
    Sword,
    Shild,
}
public class Item : MonoBehaviour
{
    public int ItemId;
    public string ItemName;
    private void Awake()
    {
        ItemName = gameObject.name;
        ItemId = (int)ItemList.Sword;
    }
}

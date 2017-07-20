using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem {

    private string itemName;
    private string itemDescription;
    private int itemID;
    private int strength;
    private int dexterity;
    private int intellegence;
    private int charisma;
    private int luck;

    public BaseItem() { }

    public enum ItemTypes {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,       
        BAG,
        SACK,
        POUCH
       
    }
    private ItemTypes itemType;

    public BaseItem(Dictionary<string, string> itemsDictionary)
    {
        itemName = itemsDictionary ["ItemName"];
        itemID = int.Parse(itemsDictionary["ItemID"]);
        itemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemsDictionary["ItemType"].ToString());

    }

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes ItemType
    {
        get { return ItemType; }
        set { ItemType = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }

    public int Intellegence
    {
        get { return intellegence; }
        set { intellegence = value; }
    }

    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }

    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }
}

using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour {

    public string itemName;
    public string description;
    public int itemID;
    public int itemAmount;
    public int price;

    public Item(string iName, string iDescription, int id, int iAmount, int iPrice) {
        iName = itemName;
        iDescription = description;
        id = itemID;
        iAmount = itemAmount;
        iPrice = price;
    }
}
using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour {


    public Item itemHolding;
    private ItemInformation itemInfo;

    public bool itemCheck;
    public GameObject canvas;
	
    private Item itemReference;
    public Text itemName;
	
    public Text description;
    public Text iItem;
    public Text iValue;

    public void Awake() {

        itemInfo = GameObject.FindGameObjectWithTag("ItemDataBase").GetComponent<ItemInformation>();
        canvas = GameObject.Find("Canvas");

        itemName = GameObject.FindGameObjectWithTag("ItemName").GetComponent<Text>();
        description = GameObject.FindGameObjectWithTag("ItemDescription").GetComponent<Text>();
        iItem = GameObject.FindGameObjectWithTag("ItemID").GetComponent<Text>();
        iValue = GameObject.FindGameObjectWithTag("ItemValue").GetComponent<Text>();

        itemName.text = null;
        description.text = null;
        iItem.text = null;
        iValue.text = null;

    }

    public void Update() {

        if (itemHolding != null) {
            itemHolding.transform.parent = transform;
            itemHolding.transform.position = transform.position;
        }

        if(itemInfo.objectDragging != null) {
            itemInfo.objectDragging.transform.position = Input.mousePosition;
        }
    }

    public void OnClick() {

        if (itemHolding == null && itemInfo.objectDragging != null) {
            itemHolding = itemInfo.objectDragging;
            itemInfo.objectDragging.transform.SetParent(transform);
            itemInfo.objectDragging = null;
        } else if (itemHolding != null && itemInfo.objectDragging == null) {
            itemInfo.objectDragging = itemHolding;
            itemHolding.transform.SetParent(canvas.transform);
            itemHolding = null;
        }
    }
	
public void OnMouseExit() {
            itemName.text = null;
            description.text = null;
            iItem.text = null;
            iValue.text = null;
    }
	
    public void OnMouseOver() {
        if (itemHolding != null) {
            itemName.text = itemHolding.itemName.ToString();
            description.text = itemHolding.description.ToString();
            iItem.text = "ItemID: " + itemHolding.itemID.ToString();
            iValue.text = "Value: " + itemHolding.price.ToString();
        }
    }

    
}

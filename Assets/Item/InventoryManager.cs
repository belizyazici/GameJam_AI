using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagement : MonoBehaviour
{
   public static InventoryManagement Instance;
   public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

   private void Awake()
    {
       Instance = this;
   }

    public void AddItem(Item item)
    {
         Items.Add(item);
    }
    public void RemoveItem(Item item)
    {
         Items.Remove(item);
    }

    public void ListItems()

    {
        foreach (Transform child in ItemContent)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;

        }          
 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item;
    void PickUp()
    {
        InventoryManagement.Instance.AddItem(Item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        PickUp();
    }
}

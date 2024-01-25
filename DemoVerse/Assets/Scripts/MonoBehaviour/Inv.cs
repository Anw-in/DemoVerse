using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*[System.Serializable]

public class InventorySlot
{
    public Item item;
    public int amount;

    public InventorySlot(Item item, int amount = 1)
    {
        this.item = item;
        this.amount = amount;
    }
}
*/
public class Inv : MonoBehaviour
{
    /*
    [SerializeField] private List<InventorySlot> items = new List<InventorySlot>();

    public void AddItems(Item item, int amount = 1)
    {
        foreach (InventorySlot slot in items)
        {
            if (slot.item.id == item.id)
            {
                slot.amount += amount;
                return;
            }
        }

        InventorySlot new_slot = new InventorySlot(item, amount);

        items.Add(new_slot);
    }

    */

    // Start is called before the first frame update
        public bool[] isFull = new bool[0];
        public GameObject[] slots = new GameObject[0];
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

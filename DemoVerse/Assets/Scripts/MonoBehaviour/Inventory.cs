using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]

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

public class Inventory : MonoBehaviour
{

    [SerializeField] private List<InventorySlot> items = new List<InventorySlot>();
    [SerializeField] private int size = 6;
    [SerializeField] public UnityEvent OnInventoryChanged;

    public int count;
    private bool open;

    public bool AddItems(Item item, int amount = 1)
    {
        Debug.Log("mm..");
        foreach (InventorySlot slot in items)
        {
            if (slot.item.id == item.id)
            {
                slot.amount += amount;
                OnInventoryChanged.Invoke();
                return true;
            }

        }

        if (items.Count >= size) return false;

        InventorySlot new_slot = new InventorySlot(item, amount);

        items.Add(new_slot);

        OnInventoryChanged.Invoke();

        return true;

     
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chest")
        {
           
            for (int i = 0; i < GetSize(); i++) 
                if (other.GetComponent<Chest>().id == items[i].item.id)
            {
                
                other.GetComponent<Animator>().Play("OpenChest");

                other.GetComponent<Chest>().open = true;

                //    count++;
                               
                // Debug.Log("T-" + other.GetComponent<Chest>().id + " items " + items[i].item.id + "Chests open: " + count); 
            }


        }



    }

 /*   private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chest" && open)
        {
            count++;
            Debug.Log("Chests open: " + count);
            open = false;
        }

    }
 */

        public Item GetItem(int i)
          
    {           
        return i < items.Count ? items[i].item : null;  
    }
        
        

    public int GetAmount(int i)
    {
        return i < items.Count ? items[i].amount : 0;
    }

    public int GetSize()
    {
        return items.Count;
    }

    /*      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {

      }
    */
}

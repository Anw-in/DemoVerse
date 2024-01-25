using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    private Inv inv;
    public GameObject slotButton;

    // Start is called before the first frame update
    private void Start()
    {
        inv = GameObject.FindGameObjectWithTag("Player").GetComponent<Inv>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("hello " );
          
            

            Debug.Log(inv.name);


          
            Debug.Log("help " );
            for (int j = 0; j < inv.slots.Length; j++)
            {

                Debug.Log("it!");
                if (inv.isFull[j] == false)
                {
                    Debug.Log("noo");
                    Destroy(gameObject);
                    Instantiate(slotButton, inv.slots[j].transform);
                    inv.isFull[j] = true;
                    break;
                } 
            }
            //    
               
                        
        }
    }


}

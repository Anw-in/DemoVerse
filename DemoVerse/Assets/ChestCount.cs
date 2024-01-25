using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChestCount : MonoBehaviour
{
    public bool open;
    public bool[] arr;




    // Start is called before the first frame update
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponentInChildren<Chest>().open) { 
            
            Chest[] op = GetComponentsInChildren<Chest>();

        for (int i = 0; i < op.Length; i++)
        {
            arr[i] = op[i].open; 

           // bool open = GetComponentInChildren<Chest>().open; 
        }
        }

        
    }
}

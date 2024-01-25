using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
   // public GameObject GO;
    [SerializeField] public int id;
    [SerializeField] public bool open;

    public Animator _a;

    



    private void OnTriggerEnter(Collider other)
    {




        if (other.tag == "Player" && open)
        {
            Debug.Log("Player win");

     

      
        }

    }
 

    // Update is called once per frame
    private void Update()
    {

    }
}

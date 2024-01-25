using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] public GameObject Resp;
 //   [SerializeField] Vector3 Rest;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Finish")
        { collision.gameObject.transform.position = Resp.transform.position; }

        if (collision.gameObject.tag == "Player") 
        { collision.gameObject.transform.position = Resp.transform.position;}
            

     /*   if (other.tag == "Finish")
        {
          //  Debug.Log(other.tag + other.transform.position + " " + this.tag + this.transform.position);
            
        }

        if (other.tag == "Respawn" && other.transform.position.y < -5f)
        {
          //  Debug.Log(other.tag + other.transform.position + " " + this.tag + this.transform.position);
        }


        if (other.tag == "Player" && other.transform.position.y < -1f) //
        {
                  other.transform.position = Resp.transform.position;

         //   Debug.Log(other.tag + other.transform.position + " " + this.tag + this.transform.position);
            // other.transform.position = Rest;
        }
     */
       
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

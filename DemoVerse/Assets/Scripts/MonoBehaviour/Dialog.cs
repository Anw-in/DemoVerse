using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public GameObject winDialog;
    public TextMeshProUGUI textDialog;
    public Button button;

    public string[] message;
    private int numDialog = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(numDialog == message.Length - 1)
            {
                button.gameObject.SetActive(false);
            }
            else
            {
                button.gameObject.SetActive(true);
                button.onClick.AddListener(NextDialog);
            }

            winDialog.SetActive(true);
            textDialog.text = message[numDialog];
        }
    }





    private void OnTriggerExit(Collider other)
    {
        winDialog.SetActive(false);
        button.onClick.RemoveAllListeners();
        numDialog = 0;
    }

    public void NextDialog()
    {
        numDialog++;
        textDialog.text = message[numDialog];
        if(numDialog == message.Length - 1)
        {
            button.gameObject.SetActive(false);
        }
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

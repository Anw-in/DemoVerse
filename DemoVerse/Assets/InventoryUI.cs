using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

    [SerializeField] private List<Image> icons = new List<Image>();
    [SerializeField] private List<TextMeshProUGUI> amounts = new List<TextMeshProUGUI>();

    public void UpdateUI(Inventory inventory)
    {
        for (int i = 0; i < inventory.GetSize() && i < icons.Count; i++)
        {
            icons[i].color = new Color(1, 1, 1, 1);
            icons[i].sprite = inventory.GetItem(i).icon;
            amounts[i].text = inventory.GetAmount(i) > 1 ? inventory.GetAmount(i).ToString() : "";
     
        }

        for (int i = inventory.GetSize(); i < icons.Count; i++)
        {
            icons[i].sprite = null;
            icons[i].color = new Color(1, 1, 1, 0);
            amounts[i].text = "";
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject rightPlace;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnMouseDown()
    {
        for(int i=0; i<inventory.slots.Length; i++)
        {
            if(inventory.isFull[i]==false)
            {
                inventory.isFull[i] = true;
                GameObject newInventoryItem = Instantiate(itemButton, inventory.slots[i].transform, false);
                newInventoryItem.GetComponent<PutMeSomewhere>().SetId(i);
                newInventoryItem.GetComponent<PutMeSomewhere>().SetRightPlace(rightPlace);
                Destroy(gameObject);
                break;
            }
        }
    }
}

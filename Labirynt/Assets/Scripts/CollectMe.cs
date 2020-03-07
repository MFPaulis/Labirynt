using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMe : MonoBehaviour
{
    public int count;
    public GameObject manager;
   
    // Update is called once per frame
    void OnMouseDown()
    {
        //Debug.Log("taken");
        manager.GetComponent<CollectingItems>().ItemCollected(count);
        Destroy(gameObject);
    }
}

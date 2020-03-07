using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    public string LevelName;
    public GameObject manager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hello player");
            if(manager.GetComponent<CollectingItems>().IfAllCollected())
            {
                other.transform.position = new Vector3(0, 0, 0);
                SceneManager.LoadScene(index);
            }
        }
    }
}


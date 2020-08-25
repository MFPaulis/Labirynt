using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOnPlaceScript : MonoBehaviour
{
    GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door");
        door.GetComponent<LevelControl>().Open();
    }
}

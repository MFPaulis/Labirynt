using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] GameObject key;

    // Start is called before the first frame update
    void Start()
    {
       key.SetActive(false);
    }

    public void ShowKey()
    {
        key.SetActive(true);
    }

}

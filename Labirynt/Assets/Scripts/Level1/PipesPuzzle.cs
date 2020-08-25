using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPuzzle : MonoBehaviour
{
    [SerializeField] GameObject plant;
    public int requiredNumber;
    int currentNumber=0;

    bool solved = false;

    // Update is called once per frame
    void Update()
    {   
        if(!solved)
        {
          if(currentNumber == requiredNumber)
            {
                plant.GetComponent<Plant>().ShowKey();
                solved = true;
            }
        }
    }

    public void addPipe()
    {
        currentNumber++;
    }
}

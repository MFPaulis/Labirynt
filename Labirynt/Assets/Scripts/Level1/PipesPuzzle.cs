using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPuzzle : MonoBehaviour
{
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
                solved = true;
            }
        }
    }

    public void AddPipe()
    {
        currentNumber++;
    }

    public bool IsSolved()
    {
        return solved;
    }
}

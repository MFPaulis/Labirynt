using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    GameObject puzzle;

    void Start()
    {
        puzzle = GameObject.Find("PipesPuzzle");
        puzzle.GetComponent<PipesPuzzle>().addPipe();
    }

}

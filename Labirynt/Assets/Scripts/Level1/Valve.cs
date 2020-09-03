using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    [SerializeField] GameObject plant;
    [SerializeField] GameObject pipesPuzzle;
    PipesPuzzle puzzle;

    // Start is called before the first frame update
    void Start()
    {
        puzzle = pipesPuzzle.GetComponent<PipesPuzzle>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if(puzzle.IsSolved())
        {
            //animacja
            plant.GetComponent<Plant>().ShowKey();
        } else
        {
            //"nic sie nie dzieje"
            Debug.Log("nic sie nie dzieje");
        }
    }


    
}

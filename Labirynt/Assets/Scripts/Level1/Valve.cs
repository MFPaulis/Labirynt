using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    [SerializeField] GameObject plant;
    [SerializeField] GameObject pipesPuzzle;
    PipesPuzzle puzzle;

    PlayerText playerText;

    // Start is called before the first frame update
    void Start()
    {
        puzzle = pipesPuzzle.GetComponent<PipesPuzzle>();
        playerText = GameObject.Find("PlayerText").GetComponent<PlayerText>() ;
    }


    void OnMouseDown()
    {
        Debug.Log("...");
        if (puzzle.IsSolved())
        {
            //animacja
            plant.GetComponent<Plant>().ShowKey();
        } else
        {
            //"nic sie nie dzieje"
            playerText.AddMessage("Nothing happened");
        }
    }


    
}

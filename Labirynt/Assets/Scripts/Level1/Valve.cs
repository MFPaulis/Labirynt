using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    [SerializeField] GameObject plant;
    [SerializeField] GameObject pipesPuzzle;
    PipesPuzzle puzzle;
    bool plantWatered;

    PlayerText playerText;

    // Start is called before the first frame update
    void Start()
    {
        puzzle = pipesPuzzle.GetComponent<PipesPuzzle>();
        playerText = GameObject.Find("PlayerText").GetComponent<PlayerText>();
        plantWatered = false;
    }


    void OnMouseDown()
    {
        if (puzzle.IsSolved())
        {
            if(!plantWatered)
            {
                //animacja
                plant.GetComponent<Plant>().ShowKey();
                plantWatered = true;
            }
            
        } else
        {
            playerText.AddMessage("Nothing happened");
        }
    }


    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    [SerializeField] GameObject plant;
    [SerializeField] GameObject pipesPuzzle;
    [SerializeField] GameObject drops;
    PipesPuzzle puzzle;
    bool plantWatered;
    PlayerText playerText;
    private Animator anim;
    bool clicked_once = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
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
                anim.SetBool("clicked_solved", true);
                drops.GetComponent<Animator>().SetBool("water", true);
                plant.GetComponent<Plant>().ShowKey();
                plantWatered = true;
            }
            
        } else if(!clicked_once)
        {
            playerText.AddMessage("Nothing happened");
            clicked_once = true;
            anim.SetBool("clicked_once", true);
        }
    }


    
}

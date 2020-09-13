using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] int numberOfButtons;
    [SerializeField] GameObject[] lights;


    public void ReleaseButtons(int color, int number)
    {
        for(int i = color*numberOfButtons; i<(color+1)*numberOfButtons; i++)
        {
            buttons[i].GetComponent<MachineButton>().ReleaseButton();
        }
        lights[color].transform.position = buttons[color * numberOfButtons + number].transform.position;
    }
}

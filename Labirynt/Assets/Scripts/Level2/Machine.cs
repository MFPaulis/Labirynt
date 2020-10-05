using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] int numberOfButtons;
    [SerializeField] GameObject[] lights;
    [SerializeField] int[] answer;
    bool puzzleSolved = false;
    [SerializeField] GameObject key;

    private void Start()
    {
        key.SetActive(false);
    }


    public void ChangeButtons(int color, int number)
    {
        for(int i = color*numberOfButtons; i<(color+1)*numberOfButtons; i++)
        {
            buttons[i].GetComponent<MachineButton>().ReleaseButton();
        }
        lights[color].transform.position = buttons[color * numberOfButtons + number].transform.position;
        buttons[color * numberOfButtons + number].GetComponent<MachineButton>().PressButton();

        puzzleSolved = true;
        for(int i = 0; i<answer.Length; i++)
        {
            if (!buttons[i * numberOfButtons + answer[i]].GetComponent<MachineButton>().isPressed())
            {
                puzzleSolved = false;
                break;
            }
        }
        if (puzzleSolved) key.SetActive(true);
        else key.SetActive(false);
    }
}

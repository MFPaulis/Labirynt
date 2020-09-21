using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineButton : MonoBehaviour
{
    [SerializeField] Machine machine;
    [SerializeField] int color;
    [SerializeField] int number;
    [SerializeField] bool pressed;

    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite pressedSprite;
    [SerializeField] Sprite releasedSprite;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        if(pressed) spriteRenderer.sprite = pressedSprite;
        else        spriteRenderer.sprite = releasedSprite;
    }


    void OnMouseDown()
    { 
        machine.ReleaseButtons(color, number);
        spriteRenderer.sprite = pressedSprite;
        pressed = true;
    }

    public void ReleaseButton()
    {
        pressed = false;
        spriteRenderer.sprite = releasedSprite;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] GameObject key;

    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite closePlant;
    [SerializeField] Sprite openPlant;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        key.SetActive(false);
        spriteRenderer.sprite = closePlant;
    }

    public void ShowKey()
    {
        key.SetActive(true);
        spriteRenderer.sprite = openPlant;
    }

}

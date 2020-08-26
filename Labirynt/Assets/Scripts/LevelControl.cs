using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int nextLevelIndex;
    public bool isOpen = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(isOpen)
        {
            if (other.CompareTag("Player"))
            {
                ChangeScene();
            }
        }
        
    }

    public void Open()
    {
        animator.SetBool("isOpen", true);
        isOpen = true;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}



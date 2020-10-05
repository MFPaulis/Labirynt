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
    private bool playerCollision = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        playerCollision = true;
        if(isOpen)
        {
            if (other.CompareTag("Player"))
            {
                ChangeScene();
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("Player")) playerCollision = false;
    }

    private IEnumerator WaitForOpening()
    {
        do
        {
            yield return null;
        } while (!animator.GetCurrentAnimatorStateInfo(0).IsName("Door_Open"));
    }

    public IEnumerator Open()
    {
        animator.SetBool("isOpen", true);
        yield return WaitForOpening();
        isOpen = true;
        if (playerCollision) ChangeScene();
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



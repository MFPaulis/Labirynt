using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerText : MonoBehaviour
{
    TextMeshPro textMeshPro;
    bool typingLock;
    Queue<string> textQueue = new Queue<string>();
    string s = "Where am I?";
    string s2 = "I need to find exit";

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        AddMessage(s);
        AddMessage(s2);
        StartCoroutine(ShowText());
    }


    IEnumerator ShowText()
    {
        textMeshPro.text = "";
        string message;

        while (true)
        {
            if (textQueue.Count != 0)
            {
                message = textQueue.Dequeue();
                for (int i = 0; i < message.Length; i++)
                {
                    textMeshPro.text += message[i];
                    yield return new WaitForSeconds(0.1f);
                }
                yield return new WaitForSeconds(1.75f);
                textMeshPro.text = "";
            } else yield return null;
        }
        
    }

    public void AddMessage(string message)
    {
        textQueue.Enqueue(message);
    }
}

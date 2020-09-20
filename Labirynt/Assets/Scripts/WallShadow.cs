using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class WallShadow : MonoBehaviour
{
    [SerializeField] GameObject Player;
    ShadowCaster2D shadowCaster2D;
    
    // Start is called before the first frame update
    void Start()
    {
        shadowCaster2D = gameObject.GetComponent<ShadowCaster2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.y > gameObject.transform.position.y-1)
        {
            shadowCaster2D.selfShadows = true;
        } else shadowCaster2D.selfShadows = false;
    }
}

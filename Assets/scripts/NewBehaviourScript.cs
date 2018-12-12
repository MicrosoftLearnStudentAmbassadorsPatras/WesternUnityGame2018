using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public static NewBehaviourScript Current;
    float pos = 0;



    // Use this for initialization
    void Start()
    {
        Current = this;
    }

    // Update is called once per frame
    public void Go()
    {
        pos += speed;
        if (pos > 1.0f)
        {
            pos = 1.0f;
        }
        var x = GetComponent<Renderer>();
        x.material.mainTextureOffset = new Vector2(pos, 0);
    }
}

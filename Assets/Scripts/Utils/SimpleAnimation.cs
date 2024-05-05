using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimation : MonoBehaviour
{
    public float speed = 500f;
    public Sprite[] sprites;
    int index = 0;
    float lastTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lastTime > speed / 1000)
        {
            lastTime = 0;
            if (sprites.Length > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
                index = (index + 1) % sprites.Length;
            }
        } else
        {
            lastTime += Time.deltaTime;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    Vector2 direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }

        gameObject.GetComponent<Rigidbody2D>().velocity = direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ghost")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPoints : MonoBehaviour
{
    public GameObject pointsParent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "point")
        {
            Destroy(collision.gameObject);
            Debug.LogWarning(collision.gameObject.transform.parent.transform.childCount);
            if (collision.gameObject.transform.parent.transform.childCount <= 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}

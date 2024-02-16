using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0.03f, 0f);
            if (transform.position.y >= 4.8)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 4.8f, 0f);
            }

        }
        if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.03f, 0f);
            if (transform.position.y <= -4.8)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -4.8f, 0f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.03f, 0f, 0f);
            if (transform.position.x >= 8.6)
            {
                var y= transform.position.y;
                transform.position = new Vector3(8.6f, y, 0f);
            }

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.03f, 0f, 0f);
            if (transform.position.x <= -8.6)
            {
                var y = transform.position.y;
                transform.position = new Vector3(-8.6f, y, 0f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.02f, 0f, 0f);
        if(transform.position.x < -13.2)
        {
            float y = transform.position.y;
            transform.position = new Vector3(14f, y, 0f);
            
        }
    }
}

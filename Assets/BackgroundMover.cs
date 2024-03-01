using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1f * Time.deltaTime, 0f, 0f);
        if (transform.position.x < -17.8)
        {
            float y = transform.position.y;
            transform.position = new Vector3(17.8f, y, 0f);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeBob : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //float speed = Random.Range(1f, 4f);
       // Vector3 RandVec = new Vector3(-Random.Range(0f, 5f), Random.Range(-5f, 5f), 0);
       // transform.Translate(Time.deltaTime * speed * RandVec);
        //Destroy(gameObject, 3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Random.Range(2f, 8f);
        transform.Translate(Time.deltaTime * speed * Vector3.left);

        if (transform.position.x < -8.2)
        {
            Destroy(gameObject);
        }
    }
}

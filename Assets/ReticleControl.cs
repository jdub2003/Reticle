using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightControl : MonoBehaviour
{
    [SerializeField] GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0.01f, 0f);
            if (transform.position.y >= 4.8)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 4.8f, 0f);
            }

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.01f, 0f);
            if (transform.position.y <= -4.8)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -4.8f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0f, 0f);
            if (transform.position.x >= 8.6)
            {
                var y= transform.position.y;
                transform.position = new Vector3(8.6f, y, 0f);
            }

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0f, 0f);
            if (transform.position.x <= -8.6)
            {
                var y = transform.position.y;
                transform.position = new Vector3(-8.6f, y, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            Instantiate(Explosion,transform.position,transform.rotation);
        }
        
    }
}

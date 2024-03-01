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
            transform.Translate(0f, 2f* Time.deltaTime, 0f);
            if (transform.position.y >= 3.7)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 3.7f, 0f);
            }

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -2f*Time.deltaTime, 0f);
            if (transform.position.y <= -3.7)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -3.7f, 0f);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(2f*Time.deltaTime, 0f, 0f);
            if (transform.position.x >= 7.88)
            {
                var y= transform.position.y;
                transform.position = new Vector3(7.88f, y, 0f);
            }

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-2f*Time.deltaTime, 0f, 0f);
            if (transform.position.x <= -7.9)
            {
                var y = transform.position.y;
                transform.position = new Vector3(-7.9f, y, 0f);
            }
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            Instantiate(Explosion,transform.position,transform.rotation);
        }*/
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire1_Sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }
}

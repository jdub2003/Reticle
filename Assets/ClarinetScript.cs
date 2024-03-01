using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class ClarinetScript : MonoBehaviour
{
    [SerializeField] AudioClip sb;
    [SerializeField] AudioClip clarinet;
    [SerializeField] AudioClip pat;
    [SerializeField] float speed;
  
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource=GetComponent<AudioSource>();
        Destroy(gameObject, 3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * 4f * Vector3.right);
    }


    //To implement point system
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //audioSource = GetComponent<AudioSource>();
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();

        if (collision.CompareTag("Patrick")==true)
        {
            audioSource=collision.gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(pat);
            gm.Score = gm.Score + 10;
            //Destroy(collision.gameObject);//destroy object we hit
            //Destroy(gameObject);

        }
        if (collision.CompareTag("Spongebob")==true)
        {
            audioSource = collision.gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(sb);
            gm.Score = gm.Score + 10;
            //Destroy(collision.gameObject);//destroy object we hit
            //Destroy(gameObject);

        }
        if (collision.CompareTag("Handsome")==true)
        {
            audioSource = collision.gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(clarinet);
            gm.Score = gm.Score - 15;
            //Destroy(collision.gameObject);//destroy object we hit
            //Destroy(gameObject);
        }
        //Debug.Log("Im triggered");
        Destroy(collision.gameObject);//destroy object we hit
        Destroy(gameObject);//destroy the fireball itself
       // find and return first object with gamemanager component
    }
}

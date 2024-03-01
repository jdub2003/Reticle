using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClarinetScript : MonoBehaviour
{
    [SerializeField] AudioClip sb;
    [SerializeField] AudioClip clarinet;
    [SerializeField] AudioClip pat;
    [SerializeField] float speed=4f;
    // Start is called before the first frame update
    private AudioSource audioSource;
    void Start()
    {
        AudioSource=GetComponent<AudioSource>();
        Destroy(gameObject, 3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.right);

        AudioSource souce = GetComponent<AudioSource>();
        souce.Play();
    }
    //To implement point system
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();

        if (collision.CompareTag("Patrick"))
        {
            AudioSource.
            collision.gameObject.GetComponent<AudioSource>().Play();
            gm.Score = gm.Score + 10;

        }
        if (collision.CompareTag("Spongebob"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            gm.Score = gm.Score + 10;

        }
        if (collision.CompareTag("Handsome"))
        {
            collision.gameObject.GetComponent<AudioSource>().Play();
            gm.Score = gm.Score - 15;
        }

        //Debug.Log("Im triggered");
        Destroy(collision.gameObject);//destroy object we hit
        Destroy(gameObject);//destroy the fireball itself
       // find and return first object with gamemanager component
    }
}

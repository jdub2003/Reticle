using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class ClarinetScript : MonoBehaviour
{
    [SerializeField] AudioSource source1;
    [SerializeField] AudioSource source2;
    [SerializeField] AudioSource source3;
    [SerializeField] float speed;
  
    // Start is called before the first frame update
    void Start()
    {
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
        
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();
        gameObject.SetActive(true);

            if (collision.CompareTag("Patrick") == true)
            {
                
                    //source1.enabled = true;
                    //source1.Play();
                    source1 = collision.gameObject.GetComponent<AudioSource>();
                    source1.Play();
            //source1.PlayOneShot(source1.clip);
                
                    gm.Score = gm.Score + 10;
            }
            if (collision.CompareTag("Spongebob") == true)
            {
                
                    //source2.enabled = true;
                    //source2.Play();
                    source2 = collision.gameObject.GetComponent<AudioSource>();
                    //source2.PlayOneShot(source2.clip);
                    source2.Play();
                    gm.Score = gm.Score + 10;
            }
            if (collision.CompareTag("Handsome") == true)
            {
                
                    //source3.enabled = true;
                    //source3.Play();
                    source3 = collision.gameObject.GetComponent<AudioSource>();
                    //source3.PlayOneShot(source3.clip);
                    source3.Play();
                    gm.Score = gm.Score - 15;
            }
            //Debug.Log("Im triggered");
            Destroy(collision.gameObject);//destroy object we hit
            Destroy(gameObject);//destroy the clarinet itself
                                // find and return first object with gamemanager component
        
    }
}

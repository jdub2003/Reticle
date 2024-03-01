using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class Patrick : MonoBehaviour
{
    bool travelDirection = true;
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    [SerializeField] GameObject SpongebobPrefab;
    [SerializeField] GameObject PatrickPrefab;
    [SerializeField] GameObject HandSquidPrefab;
    [SerializeField] float speed;
    [SerializeField] float minY = -1f;
    [SerializeField] float maxY = 1f;
    float futureTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = Random.Range(1f, 4f);
        Vector3 RandVec = new Vector3(-Random.Range(0f, 5f), Random.Range(-5f, 5f), 0);
        if (travelDirection)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.up);
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime * Vector3.up);
        }
        if (transform.position.y > maxY) //if
        {
            travelDirection = false;
        }
        if (transform.position.y < minY)
        {
            travelDirection = true;
        }


        if (Time.time > futureTime)
        {
      
            futureTime = Time.time + Random.Range(minTime, maxTime);//future time now 1 sec into the future
            int r = Random.Range(0, 100);
            if (r <= 25)
            {
                GameObject p = Instantiate(PatrickPrefab, transform.position, transform.rotation);
                p.transform.position = new Vector3(transform.position.x, Random.Range(-5f, 5f), transform.position.z);
                p.transform.Rotate(new Vector3(transform.position.x,transform.position.y,Random.Range(-11f,11f))); 
        

            }
            else if (r>25&&r<75)
            {
                GameObject sp=Instantiate(SpongebobPrefab, transform.position, transform.rotation);
                sp.transform.position = new Vector3(transform.position.x, Random.Range(-11f, 11f), transform.position.z);
                sp.transform.Rotate(new Vector3(transform.position.x, transform.position.y, Random.Range(-11f, 11f)));
            }
            else
            {
                GameObject s = Instantiate(HandSquidPrefab, transform.position, transform.rotation);
                s.transform.position = new Vector3(transform.position.x, Random.Range(-11f, 11f), transform.position.z);
                s.transform.Rotate(new Vector3(transform.position.x, transform.position.y, Random.Range(-11f, 11f)));
            }

        }

    }
}

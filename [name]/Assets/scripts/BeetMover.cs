using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeetMover : MonoBehaviour
{
    public float beatTempo;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f; 
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
        //  beatTempo * Time.deltaTime
        } */

        if (gameObject.tag == "up")
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        else if (gameObject.tag == "down")
        {
            transform.position += new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
        else if (gameObject.tag == "left")
        {
            transform.position += new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }
        else if (gameObject.tag == "right")
        {
            transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f, 0f);
        }
    }
}

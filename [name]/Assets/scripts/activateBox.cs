using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateBox : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToActivateLeft;
    public GameObject objectToActivateRight;
    public GameObject objectToActivateUp;
    public GameObject currentShield;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        objectToActivate.SetActive(false);
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentShield.SetActive(false);
            objectToActivate.SetActive(true);
            currentShield = objectToActivate;
        }

        objectToActivateLeft.SetActive(false);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentShield.SetActive(false);
            objectToActivateLeft.SetActive(true);
            currentShield = objectToActivateLeft;
        }

        objectToActivateRight.SetActive(false);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentShield.SetActive(false);
            objectToActivateRight.SetActive(true);
            currentShield = objectToActivateRight;
        }
;
        objectToActivateUp.SetActive(false);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentShield.SetActive(false);
            objectToActivateUp.SetActive(true);
            currentShield = objectToActivateUp;
        }

    }
}

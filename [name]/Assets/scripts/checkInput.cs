using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkInput : MonoBehaviour
{
    int number;
    bool perfectInput;
    float WaitForSeconds = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        while (number < 50)
        {
            number += 1;
           // WaitForSeconds(0.5f);
            Debug.Log(number);
            if (number == 50)
            {
                number = 0;

            }
        }
        perfectInput = false;
        while (perfectInput == false)
        {
            break;
        }



    }


    // Update is called once per frame
   /* private void Update()
    {
        number == 50
    }
   */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    bool counter = false;
    float TimeT = 0;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeT += Time.deltaTime;
        if (TimeT > 80)
        {

            if (counter == false)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    transform.Translate(0, 0, 4);
                    counter = true;
                }
            }

            else if (counter == true)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    transform.Translate(0, 0, -4);
                    counter = false;
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Door cannot open yet");
            }
        }
    }
}

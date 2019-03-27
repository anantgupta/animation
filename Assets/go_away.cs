using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_away : MonoBehaviour {
    float TimeT = 0;
    bool counter = false;
    public Animation anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void LateUpdate() {
        TimeT += Time.deltaTime;
        if (TimeT > 80)
        {
            GetComponent<Animator>().enabled = false;
            if (Input.GetKey(KeyCode.Space))
            {
                if (counter == false)
                {

                    //gameObject.GetComponent<Animation>().Play("mixamo.com");
                    //anim.CrossFadeQueued("mixamo.com");
                    anim.CrossFadeQueued("walk");
                    //anim.CrossFadeQueued("walk_leg2");

                    counter = true;
                }
                /*
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
                    Debug.Log("enter right");
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
                }
                */
            }
        }

    }

 
}


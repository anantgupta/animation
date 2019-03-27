using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    float TimeT = 0;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}

    // Update is called once per frame
    void LateUpdate()
    {
        TimeT += Time.deltaTime;
        if (TimeT > 80)
        {
            GetComponent<Animator>().enabled = false;
            transform.position = player.transform.position + offset;
        }
    }
}

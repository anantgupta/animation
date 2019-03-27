using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textdisplay : MonoBehaviour {
    float TimeT = 0;
    bool display = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TimeT += Time.deltaTime;
        if (TimeT > 80)
        {
            display = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }

    }

    private void OnGUI()
    {
        if (display == true)
        {
            GUI.Box(new Rect(25, 25, Screen.width-300, Screen.height - 400), "Press SPACE to open gate");
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo2 : MonoBehaviour {
    public int health;
    //Animator anim;
    public Animation anima;
    //public Animation anima = GetComponent<Animation>();
    // Use this for initialization

    public Animator zombieAnimator;

    void Start () {

        anima = GetComponent<Animation>();
	}

    void PunchZombie() {

        zombieAnimator.Play("HitReaction");

    }

    private void OnCollisionEnter(Collision collision)
    {
        //gameObject.GetComponent().runtimeAnimatorController = anima as RuntimeAnimatorController;
        
        Debug.Log("function enter");
        //anima.Play("Hit Reaction");
        Debug.Log("passed play");

        if (collision.gameObject.name == "zombie")
        {
            Destroy(collision.gameObject);
            Debug.Log("if statement enter");
            health = health - 20;
            //collision.GetComponent.< Animation > ().Play("bench sit");
            //gameObject.GetComponent<Animator>().Play("Hit Reaction");
            //collision.gameObject.GetComponent.< Animation > ().Play("Hit Reaction");
            //anima.Play("Hit Reaction");
           // Debug.Log("play called");
            //Debug.Log(health);

        }
    }
    // Update is called once per frame
    void Update () {
        //Debug.Log(health);
	}
}

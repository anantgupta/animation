using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_1 : MonoBehaviour {

    public int health;
    Animator anim;
    public RuntimeAnimatorController anima;
    void Start()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        //this.GetComponent().runtimeAnimatorController = anima as RuntimeAnimatorController;
        if (collision.gameObject.name == "zombie")
        {
            //Destroy(collision.gameObject);
            health = health - 20;
                        
            //collision.GetComponent.< Animation > ().Play("bench sit");
            if (health == 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        anim.Play("zombie_hit");
    }
    private void Update()
    {
        Debug.Log(health);
    }

}

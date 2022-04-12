using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer1 : MonoBehaviour
{
    public Animator AndarPlayer1;
    public Rigidbody rig;

    public float vel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
             AndarPlayer1.SetBool("Andar",true);
             rig.velocity = new Vector3(vel,0,0);
             
        }else{
            AndarPlayer1.SetBool("Andar",false);
        }

        if(Input.GetKey("a"))
        {
            AndarPlayer1.SetBool("AndarTras",true);
            rig.velocity = new Vector3(-vel,0,0);
        }else{
            AndarPlayer1.SetBool("AndarTras",false);
        }
        


      
        
       
    }
}

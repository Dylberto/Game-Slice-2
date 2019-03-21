using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class long_platform_trigger : MonoBehaviour
{

    public Animator platform1;
    public Animator platform2;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            platform1.SetBool("activate", true);
            platform2.SetBool("activate", true);

        }
    }

}

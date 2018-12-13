using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_shader : MonoBehaviour {


    public Material dissolve;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<player_interactions>().has_axe == true)
        {

            GetComponent<SkinnedMeshRenderer>().material = dissolve;

        }
    }

}

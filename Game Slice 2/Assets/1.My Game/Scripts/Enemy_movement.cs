using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_movement : MonoBehaviour {

    Transform player;
    NavMeshAgent navi;
    Animator dying;
    public Animator anim;
    AudioSource gibbierish;
   

	void Start () {
        //auto makes player var the player object
        player = GameObject.FindGameObjectWithTag("Player").transform;

        //gets components
        navi = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

        gibbierish = GetComponent<AudioSource>();
        enabled = true;
	}
	
	void Update () {
        //sets the nav mesh to move in the direction of the player
        navi.SetDestination(player.position);
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //triggers death animation, disables the nav mesh so stops moving, mutes audio
        if (other.tag == "Player" && other.GetComponent<player_interactions>().has_axe == true)
        {
            anim.SetBool("Death", true);

            enabled = false;

            gibbierish.mute = true;

            
        }
    }



}

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
        player = GameObject.FindGameObjectWithTag("Player").transform;

        navi = GetComponent<NavMeshAgent>();

        anim = GetComponent<Animator>();

        gibbierish = GetComponent<AudioSource>();
        enabled = true;
	}
	
	void Update () {

        navi.SetDestination(player.position);
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && other.GetComponent<player_interactions>().has_axe == true)
        {
            anim.SetBool("Death", true);

            enabled = false;

            gibbierish.mute = true;

            
        }
    }



}

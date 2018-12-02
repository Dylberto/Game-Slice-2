using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

    public Transform player;
    public Transform destination;

    private bool player_in_portal;
	
	void Update () {


        if (player_in_portal == true)
        {
            //calculates player position in relation to portal
            Vector3 portal_to_player = player.position - transform.position;
            float dot = Vector3.Dot(transform.up, portal_to_player);


            //player is in portal
            if (dot < 0f)
            {
                //teleports him

                //rotation of player 
                float ro_diff = Quaternion.Angle(transform.rotation, destination.rotation);
                ro_diff += 180;
                player.Rotate(Vector3.up, ro_diff);


                //posistion of player
                Vector3 pos_offset = Quaternion.Euler(0f, ro_diff, 0f) * portal_to_player;
                player.position = destination.position + pos_offset;



                player_in_portal = false;
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player_in_portal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player_in_portal = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_cam : MonoBehaviour {

    public Transform player_cam;
    public Transform portal;
    public Transform other_portal;

	
	void Update () {


        // gets the postion of the other camera in the world
        Vector3 player_offset_portal = player_cam.position - other_portal.position;
        transform.position = portal.position + player_offset_portal;

        // gets the rotation of the other cameras rotation in the world using the same roatation as the main camera
         float angle_diff_bet_rotations = Quaternion.Angle(portal.rotation, other_portal.rotation);

         
         Quaternion portal_ro_diff = Quaternion.AngleAxis(angle_diff_bet_rotations, Vector3.up);
         Vector3 new_cam_direc = portal_ro_diff * player_cam.forward;
         transform.rotation = Quaternion.LookRotation(new_cam_direc, Vector3.up);
         


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_texture_setup : MonoBehaviour {

    public Camera cam_blue_room;
    public Material mat_blue_room;

    public Camera cam_red_room;
    public Material mat_red_room;

    void Start () {
		
        if(cam_blue_room.targetTexture != null)
        {
            cam_blue_room.targetTexture.Release();
        }

        cam_blue_room.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

        mat_blue_room.mainTexture = cam_blue_room.targetTexture;



        if (cam_red_room.targetTexture != null)
        {
            cam_red_room.targetTexture.Release();
        }

        cam_red_room.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);

        mat_red_room.mainTexture = cam_red_room.targetTexture;
    }
	
	
}

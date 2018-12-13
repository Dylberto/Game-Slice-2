using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_interactions : MonoBehaviour {

    
    public bool has_axe = false;
    public bool dead;

    //all triggers the player will trigger
    public GameObject end_portal;
    public GameObject fireworks;
    public GameObject crazy_guy;
    public AudioSource fire;

    void Start()
    {
        //sets all objects to off until player triggers them
        fireworks.SetActive(false);
        end_portal.SetActive(false);
        crazy_guy.SetActive(false);

        dead = false;

    }

    //triggers if player collides with "x" something will tunrn on/trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Axe")
        {
            Destroy(other);

            has_axe = true;
        }

        if (other.tag == "Enemy" && has_axe == false)
        {
            SceneManager.LoadScene("start");

        }

        if (other.tag == "Enemy" && has_axe == true)
        {
            end_portal.SetActive(true);
        }

        if (other.tag == "fireworks")
        {
            fireworks.SetActive(true);
        }
        
        if(other.tag == "Spawn")
        {
            crazy_guy.SetActive(true);
        }

        if(other.tag == "Fire")
        {
            fire.mute = true;
        }
    }
}

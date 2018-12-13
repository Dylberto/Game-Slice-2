using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_interactions : MonoBehaviour {

    public bool has_axe = false;
    public bool dead;

    public GameObject end_portal;
    public GameObject fireworks;
    public GameObject crazy_guy;
    public AudioSource fire;

    void Start()
    {
        fireworks.SetActive(false);
        end_portal.SetActive(false);
        crazy_guy.SetActive(false);

        dead = false;

    }

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

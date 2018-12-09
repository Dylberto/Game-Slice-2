using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    [SerializeField] float m_PlayerHealth = 100.0f;
    // Use this for initialization
	void Start () {
		
	}

    public void DecreaseHealth()
    {
        m_PlayerHealth = m_PlayerHealth - 1f;
        CheckHealth();
        Debug.Log(m_PlayerHealth);
    }

    private void CheckHealth()
    {
        if(m_PlayerHealth <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0);
    }

}

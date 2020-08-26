using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public GameObject PanelGameOver;
    public GameObject AudioSource;

    public HealthBar healthBar;


    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;
    

    private void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource[] audio = GetComponents<AudioSource>();
        source = audio[0];
        clip1 = audio[0].clip;
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            TakeDamage(5);
        }

        if (col.gameObject.tag == "Coin")
        {
            
            Destroy(col.gameObject);
            GainHealth(5);
            Score.scoreAmount -= 3;
            source.PlayOneShot(clip1);

        }

        if (col.gameObject.tag == "construct")
        {

            
            SceneManager.LoadScene(1);

        }

        if (col.gameObject.tag == "coins")
        {

            Destroy(col.gameObject);
            GainHealth(5);
            source.PlayOneShot(clip1);
            Score.scoreAmount += 1;

        }

        if (col.gameObject.tag == "End")
        {
            Destroy(col.gameObject);

            SceneManager.LoadScene(2);

        }


    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            //PanelGameOver.SetActive(true);
            //AudioSource.SetActive(false);
            SceneManager.LoadScene(0);
        }
    }

    void GainHealth(int heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        healthBar.SetHealth(currentHealth);


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillFloor : MonoBehaviour
{
    public GameObject Player;
    //public GameObject PanelGameOver;
    //public GameObject AudioSource;

    // Start is called before the first frame update
    void Start()
    {
      Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision){
      if (collision.gameObject.tag == "Player"){
            //PanelGameOver.SetActive(true);
            SceneManager.LoadScene(0);
            //AudioSource.SetActive(false);

        }
    }
}

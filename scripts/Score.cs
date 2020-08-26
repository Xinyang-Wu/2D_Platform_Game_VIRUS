using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    static public int scoreAmount;
    private Text scoreText;
    public GameObject flags;
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + scoreAmount;
        
        if (scoreAmount >= 5)
        {
            flags.SetActive(true);
        }


        if (scoreAmount == 40)
        {
            SceneManager.LoadScene(3);
        }
    }
}

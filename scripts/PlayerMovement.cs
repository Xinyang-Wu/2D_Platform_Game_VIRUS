using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;
    bool right_click = false;

    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;




    void Update()
    {


        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        AudioSource[] audio = GetComponents<AudioSource>();
        source = audio[1];
        clip2 = audio[1].clip;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            right_click = true;
            source.PlayOneShot(clip2);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }


    }

    void FixedUpdate()
    {


        jump = false;
        //right_click = false;
        animator.SetBool("isJumping", false);
    }


    
}

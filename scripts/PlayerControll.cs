using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public GameObject VaccineToRight;
    public GameObject VaccineToLeft;
    Vector2 VacPos;
    public float fireRate = 0.5f;
    float nextFire = 0;
    bool facingright = true;
    
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {


        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        Vector2 characterScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -0.7f;
            facingright = false;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 0.7f;
            facingright = true;
        }
        transform.localScale = characterScale;

        if(Input.GetMouseButtonDown(1) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,60f), ForceMode2D.Impulse);
        }
    }

    void fire()
    {
        VacPos = transform.position;
        if (facingright == true)
        {
            VacPos += new Vector2(+1f, -0.43f);
            Instantiate(VaccineToRight, VacPos, Quaternion.identity);

        }
        else
        {
            VacPos += new Vector2(-1f, -0.43f);
            Instantiate(VaccineToLeft, VacPos, Quaternion.identity);
        }
    }
    
        
    



}

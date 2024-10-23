using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isGrounded;
    public float checkRadius;
    public Transform player;
    public Transform feetpos;//this variable will check if the playr touch the ground and then we ll say it is grounded
    public LayerMask whatisGround;
    public float jumpCount = 10f;
    public float room_door = 150f;
    public float room_out = 181f;
    public float beginning;
    public float end;
    public float beginning1;
    public float beginning2;
    private int extrajump;// doube jump variable
    public int extrajumpValue;//this is the value of extrajump. how many extra jump we want
    public Texture2D jump;
    public GameObject fight_view;
    public boos_health boss_health;
    public GameObject boss;
    public float speed1 = 4;
    public float speed2 = 18;
    public GameObject gun_point;
    private bool facing_right = true;
    private bool face_right = true;
    private Rect shootButtonRect; 
    private void Start()
    {
        extrajump = extrajumpValue;//setting extrajump value equals to extrajump.
        //gun_point = GetComponent<firepoint>();
        shootButtonRect = new Rect(20, Screen.height - 220, 200, 180); 
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        // Ground check
        isGrounded = Physics2D.OverlapCircle(feetpos.position, checkRadius, whatisGround);
        if (isGrounded)
        {
            extrajump = extrajumpValue;
        }

        //fight physics
        fight_camera();
        if (player.position.x  >= room_door && player.position.x < room_out && boss != null)
        {
            
            if (player.position.x < beginning && player.position.x > end) 
            {
                transform.Translate(Vector3.right*Time.deltaTime* speed1);
                
            }
            if (player.position.x > beginning)
            {
               
                beginning = beginning1;
                transform.Translate(Vector3.left*Time.deltaTime* speed2);
                if (facing_right == true && boss != null)
                {
                    Flip();
                }

                
                
                
            
            }
            if (player.position.x < beginning)
            {
                beginning = beginning2;
                transform.Translate(Vector3.right*Time.deltaTime* speed1);
                if (facing_right == false && boss != null)
                {
                    Flip();
                }
           
            }
        
        }
        else if (boss_health.current_health <= 0)
        {
            
            rb.velocity = new Vector2(7 , rb.velocity.y);



        }
        else
        {
            rb.velocity = new Vector2(7 , rb.velocity.y);
        }
    }
    private void Update()
    {
    
        // Handle touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // If the touch is not within the shoot button area, process jump
            if (!shootButtonRect.Contains(touch.position) && touch.phase == TouchPhase.Began)
            {
                Jump();
            }
        }
    }

    // private void OnGUI()
    // {
    //     if (GUI.Button(new Rect(Screen.width - 220, Screen.height - 220, 200, 180), jump))
    //     {
    //         Jump();
    //     }
    // }

    private void Jump()
    {
        if (isGrounded || extrajump > 0)
        {
            rb.velocity = Vector2.up * jumpCount;
            extrajump--;
        }
    }

    private void fight_camera()
    {
        if (player.position.x  >= room_door && player.position.x < room_out && boss != null)
        {
            fight_view.SetActive(true);
        }
        else
        {
            fight_view.SetActive(false);
        }
         
  
    }
    private void Flip()
    {
        facing_right = !facing_right;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
        flip_gun();
    }
    private void flip_gun()
    {
        face_right = !face_right;
        gun_point.transform.Rotate(0f, 180f, 0f);
    }
    
    
}

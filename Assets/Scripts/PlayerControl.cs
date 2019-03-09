using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    private float movementx = 0f;
    private float movementy = 0f;
    private Rigidbody2D rigidBody;
    public float ChargeSpeed = 5f;//jump/charge
    public int Mana = 120;
    public Transform Checkdat;//for platformer
    public float groundCheclRadius;
    public LayerMask groundLayer;
    private bool Wall;
    private Animator playerAnimation;
    public float radius1,radius2,radius3;
    public int dealstress1, dealstress2, dealstress3;
    public int cost1, cost2, cost3;
    public float kd1,kd2,kd3;
    public LayerMask Vrag;
    public Enemy en;
    private bool ItsTime1, ItsTime2, ItsTime3;
    private float t1=0,t2=0,t3=0;
   

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
        //FindObjectOfType<AudioManager>().Play("OST");

    }
 

    // Update is called once per frame
    void Update()
    {
        if (t1 + Time.deltaTime > kd1)
        ItsTime1 = true;
        else t1 += Time.deltaTime;

        if (t2 + Time.deltaTime > kd2)
            ItsTime2 = true;
        else t2 += Time.deltaTime;

        if (t3 + Time.deltaTime > kd3)
            ItsTime3 = true;
        else t3 += Time.deltaTime;


        movementx = Input.GetAxis("Horizontal");
        movementy = Input.GetAxis("Vertical");
        if (movementy > 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementy * speed);
        }
        else
        if (movementy < 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementy * speed);
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
        }

        if (movementx > 0f)
        {
            rigidBody.velocity = new Vector2(movementx * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(0.05457059f, 0.05457059f);
        }
        else
        if (movementx < 0f)
        {
            rigidBody.velocity = new Vector2(movementx * speed, rigidBody.velocity.y);
            transform.localScale = new Vector2(-0.05457059f, 0.05457059f);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);

        }
        //if (Input.GetButtonDown("Jump")&& IsTouchingGround)
        //{
        //    rigidBody.velocity = new Vector2(rigidBody.velocity.x, ChargeSpeed);
        //    FindObjectOfType<AudioManager>().Play("PlayerWeapon");
        //}

       playerAnimation.SetFloat("Speed", Mathf.Abs(rigidBody.velocity.x));
       // playerAnimation.SetBool("OnGround", IsTouchingGround);

    }
    //public void Perk1()
    //{

    //    if (Physics2D.OverlapCircle(Checkdat.position, radius1, Vrag)&&ItsTime1)//Проверка на наличее врага с нужным слоем в цоллайдере
    //    {
    //        vg.stress += dealstress1;
    //    }
    //    if (t1 + Time.deltaTime > kd1)
    //    {
    //        ItsTime1 = false;
    //        t1 = 0;
    //        Mana -= cost1;
    //    }
    //}
    //public void Perk2()
    //{

    //    if (Physics2D.OverlapCircle(Checkdat.position, radius2, Vrag) && ItsTime2)//Проверка на наличее врага с нужным слоем в цоллайдере
    //    {
    //        vg.stress += dealstress2;
    //    }
    //    if (t2 + Time.deltaTime > kd2)
    //    {
    //        ItsTime2 = false;
    //        t2 = 0;
    //        Mana -= cost2;
    //    }
    //}
    //public void Perk3()
    //{

    //    if (Physics2D.OverlapCircle(Checkdat.position, radius3, Vrag) && ItsTime3)//Проверка на наличее врага с нужным слоем в цоллайдере
    //    {
    //        vg.stress += dealstress3;
    //    }
    //    if (t3 + Time.deltaTime > kd3)
    //    {
    //        FindObjectOfType<AudioManager>().Play("Thunder");
    //        ItsTime3 = false;
    //        t3 = 0;
    //        Mana -= cost3;
    //    }
    //}
}

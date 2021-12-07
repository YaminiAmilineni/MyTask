using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;
    public float min_X, max_X;

    [SerializeField]
    private GameObject player_Bullet;

    [SerializeField]
    public Transform attack_Point;


    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool canAttack;

    //private Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 0f, 0.1f);
        //current_Attack_Timer = attack_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //Attack();
    }
    void MovePlayer()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            if (temp.x > max_X)
                temp.x = max_X;
            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;

            if (temp.x < min_X)
                temp.x = min_X;
            transform.position = temp;

        }
    }
    void Attack()
    {
        //attack_Timer += Time.deltaTime;
        //if (attack_Timer > current_Attack_Timer)
        //{
        //    canAttack = true;
        //} 
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (canAttack)
        //    {
        //        canAttack = false;
        //        attack_Timer = 0f;

        Instantiate(player_Bullet, attack_Point.position, Quaternion.identity);


        //    }
        //}
    }

    //void OnTriggerEnter2D(Collider2D target)
    //{

    //    if (target.tag == "Enemy")
    //    {

    //        animate.Play("Playercollapse");

    //        //if (canShoot)
    //        //{
    //        //    canShoot = false;
    //        //    CancelInvoke("StartShooting");
    //        //}

    //    }

    //    Invoke("TurnOffGameObject", 3f);
        

    
}

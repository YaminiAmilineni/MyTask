﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public float speed = 5f;
    public float rotate_Speed = 50f;

    public bool canShoot;
    public bool canRotate;
    private bool canMove = true;

    public float bound_X = -11f;
    public Transform attack_Point;
    public GameObject enemy_bullet_;

    private Animator anim;


    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        if(canRotate)
        {
            if(Random.Range(0,2)>0)
            {
                rotate_Speed = Random.Range(rotate_Speed, rotate_Speed + 20f);
                rotate_Speed *= -1f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RotateEnemy();
    }
    void Move()
    {
        if(canMove)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;

            if (temp.x < bound_X)
                gameObject.SetActive(false);

        }
    }

    void RotateEnemy()
    {
        if(canRotate)
        {
            transform.Rotate(new Vector3(0f, 0f, rotate_Speed * Time.deltaTime), Space.World);
;        }
    }


}
 
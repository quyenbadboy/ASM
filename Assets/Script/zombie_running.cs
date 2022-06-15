using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_running : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed_enemy;
    Rigidbody2D enemyRB;
    Animator ani;
    public GameObject Asset;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        ani.Play("zombie_running");

        //if(Asset != null)
        //{
        //    if (Asset.transform.position.x < transform.position.x)
        //    {
        //        transform.localScale = new Vector3(1F, 1F, 1F);
        //        transform.Translate(-Time.deltaTime * 2, 0, 0);
        //    }
        //    else
        //    {
        //        transform.localScale = new Vector3(-1F, 1F, 1F);
        //        transform.Translate(Time.deltaTime * 2, 0, 0);

        //    }
        //}
        
        //if (Time.time > nextFlip)
        //{
        //    nextFlip = Time.time + facingTime;
        //    Flip();
        //}
    }

  
}

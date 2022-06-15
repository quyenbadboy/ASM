using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Running : MonoBehaviour

{
    public Animator ani;
    public Rigidbody2D regidbody2d;
    public bool isRight = true;
    public bool isNhay;
    public bool nen_dat;
    public GameObject button_Pause;
    public GameObject text_gameOver;
    public bool IsPause = false;
    public AudioSource sound_death;
    public AudioSource sound_main;

    public Transform gunTip;

    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0;
    float OneTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        regidbody2d = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = true;
            ani.SetBool("IsRunning", true);
            ani.Play("Running");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1F, 1F, 1F);
        }
        else
        {
            ani.SetBool("IsRunning", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = false;
            ani.SetBool("IsRunning", true);
            ani.Play("Running");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1F, 1F, 1F);
        }

        //else
        //{
        //    ani.SetBool("isRunning", false);
        //}s

        //if (Input.GetKey(KeyCode.F))
        //{
        //    isRight = true;
        //    ani.SetBool("IsFighting", true);
        //    ani.Play("Fighting");

        //}
        //else
        //{
        //    ani.SetBool("IsFighting", false);
        //}

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (nen_dat == true)
            {
                if (isRight == true)
                {
                    ani.SetBool("IsNhay", true);
                    ani.Play("Juming");
                    regidbody2d.velocity = Vector2.up * 7;
                }
                else
                {
                    ani.SetBool("IsNhay", true);
                    ani.Play("Juming");
                    regidbody2d.velocity = Vector2.up * 7;
                }
            }
            nen_dat = false;
        }
        else
        {
            ani.SetBool("IsNhay", false);
        }



        if (Input.GetKey(KeyCode.P))
        {
            IsPause = !IsPause;
            if (IsPause == true)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }


        if (Input.GetAxisRaw("Fire1") > 0)
        {
            fireBullet();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "nen_dat")
        {
            nen_dat = true;
            OneTime = OneTime + 1f;
            if (OneTime == 2)
            {
                StartGame();
            }
            else
            {
                StopRoi();
            }

        }

        if (collision.gameObject.tag == "gioi_hanphai")
        {
            SceneManager.LoadScene("Man2");
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rot_xuong")
        {
            StartCoroutine(StopGame());

            sound_main.Stop();
            sound_death.Play();
            button_Pause.SetActive(true);
            text_gameOver.SetActive(true);
            ani.SetBool("IsDeath", true);
            ani.Play("IsDeath");
            regidbody2d.velocity = Vector2.up * 7;
            Destroy(GameObject.Find("asset"), 1);
            //Time.timeScale = 0;
        }
    }

    void fireBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            if (isRight == true)
            {
                ani.SetBool("IsBan", true);
                ani.Play("IsBan");
                Instantiate(bullet, gunTip.position, transform.localRotation);

            }
            else
            {
                ani.SetBool("IsBan", true);
                ani.Play("IsBan");
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            }
        }
        else
        {
            ani.SetBool("IsBan", false);
        }
    }

    public IEnumerator StopGame()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 0;

    }

    public void StartGame()
    {
        ani.SetBool("IsRoi", true);
        ani.Play("isRoi");
    }

    public void StopRoi()
    {
        ani.SetBool("IsRoi", false);
    }
}

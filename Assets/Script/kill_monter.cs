using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kill_monter : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    public int diemTong_man1 = 0;
    int diemTong_man2 = 0;
    public GameObject diemText;
    public GameObject PSCoins;
    public GameObject button_Pause;
    public GameObject text_gameOver;
    public AudioSource sound_main;
    public AudioSource sound_death;
    public AudioSource sound_eat;
    public AudioSource sound_kill;
    public AudioSource sound_win;
    public Rigidbody2D regidbody2d;
    public GameObject tran_quyen;
    public GameObject you_win;
    public GameObject cuc_da;
    public GameObject cuc_da_win;
    public GameObject cuc_da_chan_win;

    void Start()
    {
        ani = GetComponent<Animator>();
        regidbody2d = GetComponent<Rigidbody2D>();

        sound_main.Play();
        AddPoint(0);
    }

    public void AddPoint(int diem)
    {

        total_Score.totalScore += diem;
        diemText.GetComponent<Text>().text = "Score : " + total_Score.totalScore;
    }
    // Update is called once per frame
    void Update()
    {
        diemTong_man2 = diemTong_man1;
        AddPoint(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.attachedRigidbody.name;
        if(collision.gameObject.tag == "ben_trai")

        {
            sound_main.Stop();
            sound_death.Play();
            ani.SetBool("IsDeath", true);
            ani.Play("IsDeath");
            regidbody2d.velocity = Vector2.up * 7; 
            Destroy(GameObject.Find("asset"), 1);
            button_Pause.SetActive(true);
            text_gameOver.SetActive(true);
            
        }
        else if (collision.gameObject.tag == "ben_tren")
        {
            sound_kill.Play();
            Destroy(GameObject.Find(name));
            AddPoint(2);
        }

        if(collision.gameObject.tag == "kim_cuong")
        {
            sound_eat.Play();
            Destroy(GameObject.Find(name));
            AddPoint(1);
            Instantiate(PSCoins, collision.gameObject.transform.position, collision.gameObject.transform.localRotation);
        }

        if (collision.gameObject.tag == "gold")
        {
            sound_eat.Play();
            Destroy(GameObject.Find(name));
            AddPoint(1);
        }

        if (collision.gameObject.tag == "cuc_da")
        {
            sound_eat.Play();
            tran_quyen.SetActive(true);
            
        }

        if (collision.gameObject.tag == "cup")
        {
            
            SceneManager.LoadScene("Win");
            
        }

        if (collision.gameObject.tag == "pin")
        {
            Destroy(GameObject.Find(name));
            sound_eat.Play();
            cuc_da_win.SetActive(true);
            cuc_da_chan_win.SetActive(false);
        }
    }
}

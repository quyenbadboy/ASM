using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class be_nam : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHeath = 100f;
     float nowHeath;
    public bool gioihan_trai;
    public AudioSource sound_kill;
    public GameObject after_kill;
    //kill_monter kill = new kill_monter();
    // mau cho be_nam
    public Slider slider_heath;
    public GameObject cuc_da_chan_Win;
    public GameObject cuc_da_Win;

    void Start()
    {
        nowHeath = maxHeath;
        slider_heath.maxValue = maxHeath;
        slider_heath.value = maxHeath;
        //kill = GetComponent<kill_monter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gioihan_trai == true)
        {
            transform.Translate(Time.deltaTime * 2, 0, 0);
            transform.localScale = new Vector3(1F, 1F, 1F);
        }
        else
        {
            transform.Translate(-Time.deltaTime * 2, 0, 0);
            transform.localScale = new Vector3(-1F, 1F, 1F);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "gioihan_trai")
        {
            
            gioihan_trai = true;
        }else if (collision.gameObject.tag == "gioihan_phai")
        {
            
            gioihan_trai = false;
            
        }
    }

    public void addDame(float damage)
    {
        slider_heath.gameObject.SetActive(true);
        nowHeath -= damage;
        slider_heath.value = nowHeath;
        if(nowHeath <=0)
        {

            sound_kill.Play();
            Destroy(gameObject);
            Instantiate(after_kill, transform.position, transform.rotation);
            
        }
    }

    public void addDamezomebie_win(float damage)
    {
        slider_heath.gameObject.SetActive(true);
        nowHeath -= damage;
        slider_heath.value = nowHeath;
        if (nowHeath <= 0)
        {

            sound_kill.Play();
            Destroy(gameObject);
            Instantiate(after_kill, transform.position, transform.rotation);
            cuc_da_chan_Win.SetActive(false);
            cuc_da_Win.SetActive(true);
        }
    }
}

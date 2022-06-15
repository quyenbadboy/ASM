using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimbay : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator ani;
    public bool gioihan_trai;
    void Start()
    {
        ani = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (gioihan_trai == true)
        {
            ani.SetBool("Chimbay", true);
            ani.Play("chim_bay");
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            ani.SetBool("Chimbay", true);
            ani.Play("chim_bay");
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gioihan_trai")
        {
            gioihan_trai = true;
        }
        else if (collision.gameObject.tag == "gioihan_phai")
        {
            gioihan_trai = false;
        }
    }
}

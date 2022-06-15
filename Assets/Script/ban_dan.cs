using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ban_dan : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed;
    Rigidbody2D myBody;
    float mau_be_nam = 40f;
    

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0)
        {
            myBody.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);

        }
        else
        {
            myBody.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse);

        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(GameObject.Find("Projiect(Clone)"), 2);
    }
    public void removeBullet()
    {
        myBody.velocity = new Vector2(0F, 0F);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        be_nam be_Nam = collision.gameObject.GetComponent<be_nam>();
        if (collision.gameObject.tag == "be_nam")
        {


            if (collision.gameObject.layer == LayerMask.NameToLayer("eneme"))
            {
                Destroy(gameObject);
           
                be_Nam.addDame(mau_be_nam);

            }

            if (collision.gameObject.layer == LayerMask.NameToLayer("enemewin"))
            {
                Destroy(gameObject);

                be_Nam.addDamezomebie_win(mau_be_nam);

            }

        }
    }


}

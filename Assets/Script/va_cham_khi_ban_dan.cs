using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class va_cham_khi_ban_dan : MonoBehaviour
{
    // Start is called before the first frame update
    
    ban_dan ban;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag== "be_nam")
        {
            //ban.removeBullet();
            //Destroy(GameObject.Find("Mushroom1"));
        }
    }
}

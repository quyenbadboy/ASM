using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die_map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        string name_map = collision.attachedRigidbody.gameObject.name;
        GameObject.Find(name_map);
        transform.Translate(0, Time.deltaTime*5, 0);
    }
}

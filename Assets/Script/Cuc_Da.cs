using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuc_Da : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    void Start()
    {
        
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            obj.SetActive(true);
        }
        
        }
}

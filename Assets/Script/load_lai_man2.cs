using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_lai_man2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Man1()
    {
        SceneManager.LoadScene("Man1");
    }
    public void Man2()
    {
        SceneManager.LoadScene("Man2");
    }
}

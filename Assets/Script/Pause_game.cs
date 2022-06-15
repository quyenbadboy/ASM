using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button_resum;
    public GameObject button_pause;
    public GameObject button_music;
    public GameObject button_cheo_music;
    public AudioSource music;
    bool isMussic = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {

        button_resum.SetActive(true);
        button_pause.SetActive(false);
        button_music.SetActive(true);
        Time.timeScale = 0;
    }

    public void resumGame()
    {
        button_resum.SetActive(false);
        button_pause.SetActive(true);
        button_music.SetActive(false);
        Time.timeScale = 1;
    }

    public void butonmusic()
    {
        isMussic = !isMussic;
        if(isMussic == false)
        {
            music.Stop();
            button_cheo_music.SetActive(true);
        }
        else
        {
            music.Play();
            button_cheo_music.SetActive(false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tong_Diem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject diemTong;
    void Start()
    {
        tongdiem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tongdiem()
    {
        diemTong.GetComponent<Text>().text = "You Score : " + total_Score.totalScore;
    }
}

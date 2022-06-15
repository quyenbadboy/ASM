using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float smoothing;
    Vector3 ofset;
    float lowY;

    void Start()
    {
        ofset = transform.position - target.position;

        lowY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target != null)
        {
            Vector3 targetCamPos = target.position + ofset;

            transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

            if (transform.position.y < lowY)
            {
                transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
            }

            if (transform.position.y > lowY)
            {
                transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
            }
        }
       

        
        
    }

    private void LateUpdate()
    {
    }

}

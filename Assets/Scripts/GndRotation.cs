using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GndRotation : MonoBehaviour {

    // Update is called once per frame
    void FixedUpdate()
    {   
        if(Time.fixedTime < 30) {
            transform.Rotate(new Vector3(45, 0, 0) * Time.deltaTime / 5);
        }
        else if(Time.fixedTime >30 && Time.fixedTime <60)
        {
            transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime / 5);
        }
        else
        {
            transform.Rotate(new Vector3(45, 45, 0) * Time.deltaTime / 5);
        }
        
    }
}

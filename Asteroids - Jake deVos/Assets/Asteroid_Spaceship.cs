using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        

        bool rotationleft = Input.GetKey(KeyCode.LeftArrow);
        bool rotationright = Input.GetKey(KeyCode.RightArrow);
        bool moveforward = Input.GetKey(KeyCode.UpArrow);
        bool shootblast = Input.GetKey(KeyCode.Space);

        float rotate = 0;
        if (rotationleft)
            rotate += 300 * Time.deltaTime;

        
        if (rotationright)
            rotate -= 300 * Time.deltaTime;

        transform.rotation 
            = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        if (moveforward)
            transform.position += transform.up * 5f * Time.deltaTime;
    }
}

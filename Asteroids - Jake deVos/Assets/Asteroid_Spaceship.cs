using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Shooting mechanic object and speed
    public GameObject pewpew;
    public float pewpewspeed = 3f;
    public Rigidbody2D rb;
    void Start()
    {

    }

    void Update()
    {
        
        //Get player inputs for rotation, acceleration, and the shooting mechanic
        bool rotationleft = Input.GetKey(KeyCode.LeftArrow);
        bool rotationright = Input.GetKey(KeyCode.RightArrow);
        bool moveforward = Input.GetKey(KeyCode.UpArrow);
        bool shootblast = Input.GetKeyDown(KeyCode.Space);

        //Rotation controls
        float rotate = 0;
        if (rotationleft)
            rotate += 300 * Time.deltaTime;

        
        if (rotationright)
            rotate -= 300 * Time.deltaTime;

        transform.rotation 
            = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        //Control to move forwards
        if (moveforward)
        {
            rb.AddForce(transform.up * 2);
        }
        

        //Shooting mechanism
        if (shootblast)
        {
            Vector3 position = transform.position + transform.up;
            GameObject pewpewInstance = Instantiate(pewpew, position, Quaternion.identity);
            Rigidbody2D rigidbody = pewpewInstance.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(transform.up * pewpewspeed, ForceMode2D.Impulse);

            Destroy(pewpewInstance, 3);
        }
    }
}


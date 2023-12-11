using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Asteroid_Rocks : MonoBehaviour
{
    public GameObject rock;
    public float rockspeed = 3f;
    void Start()
    {
        float x = Random.Range(10f, -10f);
        float y = Random.Range(5f, -5f);
        transform.position = new Vector3(x, y, 0);

        bool move = false;

        float rotate = Random.Range(0f, 360f);

        transform.rotation
        = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        //if (move = false)
        //{
        //    transform.position += transform.up * 5f * Time.deltaTime;
        //}

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * rockspeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
}

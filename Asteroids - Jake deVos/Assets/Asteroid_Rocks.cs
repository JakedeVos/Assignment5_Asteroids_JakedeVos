using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Asteroid_Rocks : MonoBehaviour
{
    //Get asteroid object and asteroid speed
    public GameObject rock;
    public float rockspeed = 3f;
    
    void Start()
    {
        //Spawn asteroid on random spot on the screen
        float x = Random.Range(10f, -10f);
        float y = Random.Range(5f, -5f);
        transform.position = new Vector3(x, y, 0);

        
        //Rotate the asteroid in a random direction
        float rotate = Random.Range(0f, 360f);

        transform.rotation
        = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        //Add rigidbody
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * rockspeed, ForceMode2D.Impulse);
    }
    
    //Get blasts to collide with asteroid and break them
    private void OnCollisionEnter2D(Collision2D collision) 
    {

        if (!collision.gameObject.CompareTag("pewpew"))
        
            return;

        SplitThisObject();
        Destroy(collision.gameObject);
    }

    //Get asteroid to split into multiple smaller asteroids
    private int splitCount;
    void SplitThisObject()
    {
        GameObject number1 = Instantiate(gameObject);
        GameObject number2 = Instantiate(gameObject);
        number1.transform.localScale = number1.transform.localScale / 2f;
        number2.transform.localScale = number2.transform.localScale / 2f;
        number1.GetComponent<Asteroid_Rocks>().splitCount++;
        number2.GetComponent<Asteroid_Rocks>().splitCount++;

        Destroy(gameObject);
    }

}

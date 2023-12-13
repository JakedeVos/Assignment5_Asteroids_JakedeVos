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

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (!collision.gameObject.CompareTag("pewpew"))
            return;

        SplitThisObject();
        Destroy(collision.gameObject);
    }

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

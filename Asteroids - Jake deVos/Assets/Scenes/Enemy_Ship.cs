using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship : MonoBehaviour
{
    //Get enemy object and enemy ship speed
    public GameObject enemyship;
    public GameObject pewpew;
    public float enemyshipspeed = 4f;
    public float pewpewspeed = 6f;

    void Start()
    {
        //Spawn enemy ship randomly on the screen
        float x = Random.Range(10f, -10f);
        float y = Random.Range(5f, -5f);
        transform.position = new Vector3(x, y, 0);

        //Rotate enemy ship in a random direction
        float rotate = Random.Range(0f, 360f);

        transform.rotation
        = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        //Add rigidbody
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * enemyshipspeed, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {

        if (!collider.gameObject.CompareTag("pewpew"))

        Destroy(collider.gameObject);
    }
}

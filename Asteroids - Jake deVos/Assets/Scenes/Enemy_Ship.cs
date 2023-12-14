using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship : MonoBehaviour
{

    public GameObject enemyship;
    public float enemyshipspeed = 4f;

    void Start()
    {
        float x = Random.Range(10f, -10f);
        float y = Random.Range(5f, -5f);
        transform.position = new Vector3(x, y, 0);



        float rotate = Random.Range(0f, 360f);

        transform.rotation
        = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + rotate);

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * enemyshipspeed, ForceMode2D.Impulse);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_BoarderTeleportation : MonoBehaviour
{
    //Allow all objects/sprites to be teleported across the screen
    [field: SerializeField] public Vector3 Offset { get; set; }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {

        Vector3 newPosition = collider2D.transform.position + Offset;
        collider2D.attachedRigidbody.MovePosition(newPosition);
    }
}


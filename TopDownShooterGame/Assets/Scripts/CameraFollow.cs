using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEmptyCSharpScript : MonoBehaviour 
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosistion = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosistion; 
    }
}

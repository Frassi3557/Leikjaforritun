using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    private Vector3 offset;

    public float camPosX;
    public float camPosY;
    public float camPosZ;

    public float camRotationX;
    public float camRotationY;
    public float camRotationZ;

    public float turnSpeed;

    void Start()
    {
        offset = new Vector3(player.position.x - camPosX, player.position.y - camPosY, player.position.z - camPosZ);
        transform.rotation = Quaternion.Euler(camRotationX, camRotationY, camRotationZ);
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}

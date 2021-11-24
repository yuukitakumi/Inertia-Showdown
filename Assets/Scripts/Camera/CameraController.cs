using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        //mendapatkan offset antara target dan camera
        offset = transform.position - target.position;
    }
    private void FixedUpdate()
    {
        //mendapatkan posisi kamera
        Vector3 targetCamPos = target.position + offset;

        //set posisi camera dengan smoothing
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}

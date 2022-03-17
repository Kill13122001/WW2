using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerrotation : MonoBehaviour
{
    public GameObject player;
    public Transform cameraa;
    public float mousesenstivity;
    public float xrotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * mousesenstivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * mousesenstivity * Time.deltaTime;
        xrotation -= y;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        cameraa.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        player.transform.Rotate(player.transform.up * x);
    }
}

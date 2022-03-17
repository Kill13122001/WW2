using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public GameObject player;
    public CharacterController playercontroller;
    public float movementspeed;
    float verticalvelocity;
    public float g;
    public float jumpvelocity;
    public bool t;
    public GameObject checksphere;
    public LayerMask groundmask;
    

    private void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {

            
            
        }
        if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            
        }
        t = Physics.CheckSphere(checksphere.transform.position, 0.2f, groundmask);
        float x = Input.GetAxis("Horizontal") * movementspeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movementspeed * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && t)
        {
            verticalvelocity = jumpvelocity;
        }
        playercontroller.Move(playercontroller.transform.up * verticalvelocity * Time.deltaTime);
        verticalvelocity -= g * Time.deltaTime;
        playercontroller.Move(player.transform.right * x );
        playercontroller.Move(player.transform.forward * y);
       

    }
}

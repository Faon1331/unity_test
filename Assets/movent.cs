using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movent : MonoBehaviour
{
    [SerializeField] Rigidbody rb = new Rigidbody();
    [SerializeField] float speed = 5f;
    [SerializeField] int jumps = 2;
    [SerializeField] GameObject maincamera;
    [SerializeField] float jumpforce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-maincamera.transform.right * speed * Time.deltaTime, ForceMode.Impulse); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(maincamera.transform.right * speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(maincamera.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-maincamera.transform.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumps>0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector2.up*jumpforce, ForceMode.Impulse);
            jumps --;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Floor")
        {
            jumps = 2; 
        }
    }
}

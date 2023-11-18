using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collishen_check : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Floor")
        {
            Debug.Log("Floor");
        }
        
    }
}

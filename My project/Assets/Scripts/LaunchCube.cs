using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }

        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += transform.forward * m_Thrust * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * m_Thrust * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * m_Thrust * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * m_Thrust * Time.deltaTime;
        }
    }
}

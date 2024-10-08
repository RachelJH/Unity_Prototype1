using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;

    [SerializeField] float turnSpeed = 45.0f;

    private float horizontalInput;

    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //�յ�
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //ȸ��
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}

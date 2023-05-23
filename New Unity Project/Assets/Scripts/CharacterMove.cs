using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform cameraTransform;   // ī�޶� ������
    public CharacterController characterController; // CharacterController�� 3D ������Ʈ ����
    public float moveSpeed = 10f;   // �̵� �ӵ�
    public float gravity = -20f;
    public float yVelocity = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 playerPosition = transform.position;

        Vector3 moveDirection = new Vector3(h, 0, v);

        moveDirection = cameraTransform.TransformDirection(moveDirection);  // ī�޶� ��ġ
        moveDirection *= moveSpeed;

        yVelocity += gravity * Time.deltaTime;

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}

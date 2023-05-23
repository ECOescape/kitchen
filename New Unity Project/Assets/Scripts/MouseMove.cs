using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 500f; // ���콺 �ΰ���
    public float rotationX;         // X���� ��ġ
    public float rotationY;         // Y���� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");
        float mouseMoveY = Input.GetAxis("Mouse Y");

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        rotationX += mouseMoveY * sensitivity * Time.deltaTime;

        if (rotationX > 90f)
		{
            rotationX = 90f;
		}
        else if (rotationX < -90f)
		{
            rotationX = -90f;
		}            

        transform.eulerAngles = new Vector3(-rotationX, rotationY, 0);
    }
}

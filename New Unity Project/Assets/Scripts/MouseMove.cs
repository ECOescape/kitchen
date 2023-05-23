using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 500f; // 마우스 민감도
    public float rotationX;         // X축의 위치
    public float rotationY;         // Y축의 위치

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

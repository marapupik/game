using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    
    // �������� ��������
    public float speed = 5f;

    // ����� ���������
    public Transform stopPoint;

    // ������� ��� ������������ ������� �������� �������
    private int objectCount = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ��������, ������ �� ������ ����� ���������
        if (transform.position.x >= stopPoint.position.x)
        {
            // ��������� ��������
            speed = 0f;
        }
        else
        {
            // ��������, �������� �� ������ "�������"
            if (objectCount % 3 != 0)
            {
                // �������� �� ��� X
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            // ���������� ��������
            objectCount++;
        }
    }
    public Transform startPosition;
    // ��������� ��������
    private void OnCollisionEnter(Collision collision)
    {
        // ������� �� ��������� �������
        transform.position = startPosition.position;

        // ����� ��������
        objectCount = 0;

        // ������������� ��������
        speed = 5f;
    }
}


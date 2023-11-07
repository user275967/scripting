using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health = 5;

    //������� NPC
    public int level = 1;

    //�������� NPC
    public float speed = 1.2f;


    void Start()
    {
        health = health + level;
        print("������: " + health);
    }

    void Update()
    {
        //������ ���������� ���� Vector3 � ��������� � �� ������� NPC
        Vector3 newPosition = transform.position;

        //������ ������� NPC �� ��� z �������� �������� NPC � ������� ����� �������
        newPosition.z += speed * Time.deltaTime;

        //������ ������� NPC �� ����� ��������, ������������ ����
        transform.position = newPosition;
    }
}

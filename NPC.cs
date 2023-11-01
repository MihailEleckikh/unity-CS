using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health;
    public int level = 1;
    public float speed = 1.2f;
    Vector3 position;
    // Start is called before the first frame update
    void Start(){
        health = 5;
        health += level; // �������� ������� �� ������ ���������
        print(health); // ��������� �������� �������� ���������
        gameObject.transform.position = new Vector3(0, 0.5f, -34); // ����������� ������� ���������
    }

    // Update is called once per frame
    void Update(){
        position = gameObject.transform.position; // ���������� ������������� �������� ������� ���������
        position.z += speed * Time.deltaTime; // ���������� �� Z ������������� �������� ������� * ��������
        gameObject.transform.position = position; // ������� ����������� �������� ����������
    }
}

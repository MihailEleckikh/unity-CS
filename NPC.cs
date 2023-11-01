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
        health += level; // здоровье зависит от уровня персонажа
        print(health); // выводится значение здоровья персонажа
        gameObject.transform.position = new Vector3(0, 0.5f, -34); // изначальная позиция персонажа
    }

    // Update is called once per frame
    void Update(){
        position = gameObject.transform.position; // переменной присваивается значение позиции персонажа
        position.z += speed * Time.deltaTime; // переменной по Z присваивается значение времени * скорость
        gameObject.transform.position = position; // позиции применяется значение переменной
    }
}

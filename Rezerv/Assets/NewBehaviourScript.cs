using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    // Скорость движения
    public float speed = 5f;

    public Transform startPosition;
    // Точка остановки
    public Transform stopPoint;

    // Счетчик для отслеживания каждого третьего объекта
    private int objectCount = 0;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Проверка, достиг ли объект точки остановки
        if (transform.position.x >= stopPoint.position.x)
        {
            // Остановка движения
            speed = 0f;
        }
        else
        {
            // Проверка, является ли объект "третьим"
            if (objectCount % 3 != 0)
            {
                // Движение по оси X
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            // Увеличение счетчика
            objectCount++;
        }
    }

    // Обработка коллизий
    private void OnCollisionEnter(Collision collision)
    {
        // Возврат на стартовую позицию
        transform.position = startPosition.position;

        // Сброс счетчика
        objectCount = 0;

        // Возобновление движения
        speed = 5f;
    }
}

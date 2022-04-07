using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequiredComponent(typeof(ImputController))]
public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] float _speed = 0f;
    [SerializeField] float _rotation = 0f;

    ImputController _ImputController = null;


    // Start is called before the first frame update
     void Awake()
    {
        _ImputController - GetComponent<ImputController>;



    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        vector1 Imput= _ImputController.MoveImput

            transform.position += transform.position * Imput.y * _speed * Time.deltatime


    }

}

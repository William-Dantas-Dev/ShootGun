using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetPackController : MonoBehaviour
{
    public float _speed = 10f;
    void Start()
    {

    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        MoveCharacter(new Vector2(horizontal, vertical));
    }

    private void MoveCharacter(Vector2 _direction)
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}

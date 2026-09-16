using System;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private GameObject _player;
    public float speed = 3f;
    
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        Vector3 direction = (_player.transform.position - transform.position).normalized;
        direction.y = 0;
        Vector3 velocity = direction * speed;
        
        transform.position += velocity * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
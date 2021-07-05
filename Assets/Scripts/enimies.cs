using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimies : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.GetComponent<bird>()!=null)
        {
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(collision.collider.GetComponent<enimies>()!=null)
        {
            return;
        }
        if(collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
            Instantiate(_cloudParticlePrefab, transform.position, Quaternion.identity);
        }
    }
}

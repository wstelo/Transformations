using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(new Vector3(_speed * Time.deltaTime, transform.position.y, transform.position.z));
    }
}

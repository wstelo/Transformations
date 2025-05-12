using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformer : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime, _scaleSpeed * Time.deltaTime);
        transform.RotateAround(transform.position, transform.up, _rotateSpeed * Time.deltaTime);
        transform.Translate(transform.forward * Time.deltaTime * _movementSpeed);
    }
}

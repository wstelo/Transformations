using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * _movementSpeed);
    }
}

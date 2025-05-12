using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * (_scaleSpeed * Time.deltaTime);
    }
}

using UnityEngine;

public class Sun : MonoBehaviour
{
    [SerializeField] private float _hours = 0.1f;
    [SerializeField] private float _rotationVelocity = 1;

    void FixedUpdate()
    {
        _hours++;
        transform.rotation = Quaternion.Euler(_hours * _rotationVelocity * Time.deltaTime, 0, 0);
    }
}

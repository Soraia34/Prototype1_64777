using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public const float rotationSpeedSpin = 900;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeedSpin * Time.deltaTime);
    }
}

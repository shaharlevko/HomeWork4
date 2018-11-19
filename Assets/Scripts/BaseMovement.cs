using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseMovement : MonoBehaviour
{
    public bool UsePhysics;
    public float BaseForceMultiplier = 10.0f;
    
    public void Move(Vector2 value)
    {
        if (UsePhysics)
        {
            GetComponent<Rigidbody2D>().AddForce(value * BaseForceMultiplier);
        }
        else
        {
            GetComponent<Transform>().Translate(value);
        }
    }
}

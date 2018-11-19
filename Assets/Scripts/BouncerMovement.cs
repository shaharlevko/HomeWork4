using UnityEngine;

public class BouncerMovement : BaseMovement
{
    public Vector2 Direction = Vector2.down; 
    public float Speed = 5;
    
    private void Update()
    {
        Move(Direction * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Direction *= -1f;
    }
}

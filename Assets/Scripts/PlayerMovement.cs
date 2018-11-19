using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : BaseMovement
{
    public Vector2 LeftThruster;
    public Vector2 RightThruster;

    private void FixedUpdate()
    {
        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force += LeftThruster;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            force += RightThruster;
        }
        
        Move(force);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collided with object: " + other.gameObject.name);

        if (other.gameObject.CompareTag("good"))
        {
            Debug.Log("Hit a good object!");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("bad"))
        {
            Debug.Log("Hit a bad object!");
            SceneManager.LoadScene(0);
        }
    }
}

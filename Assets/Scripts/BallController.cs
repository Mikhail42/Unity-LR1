using UnityEngine;

public class BallController : MonoBehaviour
{

    void OnMouseDown()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 pos = other.transform.position - transform.position;
        Vector2 force = new Vector2(pos.x, pos.y) * 0.9f;
        GetComponent<Rigidbody2D>().AddForce(force);
    }
}
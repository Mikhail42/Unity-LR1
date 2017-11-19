using UnityEngine;

public class BallController : MonoBehaviour
{
    void OnMouseDown()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.red;
    }
}

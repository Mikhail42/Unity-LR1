using UnityEngine;

public class Ball
{
    private readonly Color initColor;
    // private Color color;

    public GameObject GameObject { get; set; }
    
    public Ball(GameObject gameObject)
    {
        GameObject = gameObject;
        Renderer rend = gameObject.GetComponent<Renderer>();
        initColor = rend.material.color;
    }

    public void AddForce(Vector2 force)
    {
        Rigidbody2D rb2d = GameObject.GetComponent<Rigidbody2D>();
        rb2d.AddForce(force);
    }

    public void SetInitColor()
    {
        Renderer rend = GameObject.GetComponent<Renderer>();
        rend.material.color = initColor;
    }

    public bool IsSelected()
    {
        Renderer rend = GameObject.GetComponent<Renderer>();
        return Color.red.Equals(rend.material.color);
    }

    override public string ToString()
    {
        Renderer rend = GameObject.GetComponent<Renderer>();
        return "Color: " + rend.material.color + ". Object: " + GameObject;
    }
}
using UnityEngine;

public class Ball
{
    private readonly Material material;
    private readonly Color initColor;
    private readonly Rigidbody2D rb2d;
    
    public Ball(Rigidbody2D ballRb2d, Color initColor)
    {
        material = ballRb2d.gameObject.GetComponent<Renderer>().material;
        material.color = initColor;
        this.initColor = initColor;
        rb2d = ballRb2d;
        rb2d.gameObject.SetActive(true);
    }

    public void AddForce(Vector2 force)
    {
        rb2d.AddForce(force);
    }

    public void SetInitColor()
    {
        material.color = initColor;
    }

    public bool IsSelected()
    {
        return Color.red.Equals(material.color);
    }
}
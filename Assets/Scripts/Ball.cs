using UnityEngine;

public class Ball
{
    private readonly Material material;
    private readonly Color initColor;
    private readonly Rigidbody2D rb2d;
    
    public Ball(GameObject gameObject, Vector3 wordPosition, Color initColor)
    {
        material = gameObject.GetComponent<Renderer>().material;
        material.color = initColor;
        this.initColor = initColor;
        rb2d = gameObject.GetComponent<Rigidbody2D>();

        gameObject.transform.SetPositionAndRotation(wordPosition, new Quaternion());
        gameObject.SetActive(true);
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
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public static readonly float CAMERA_Z = 10f;
    private static readonly System.Random randomGen = new System.Random();

    public GameObject ball;

    //public Rigidbody2D rb2d;
    private List<Ball> balls;

    void Start()
    {
        balls = new List<Ball>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            OnRightClick();
        }
    }

    void OnMouseDown()
    {
        Vector3 wordPosition = Input.mousePosition;
        wordPosition.z = CAMERA_Z;
        wordPosition = Camera.main.ScreenToWorldPoint(wordPosition);

        Color initColor = new Color(randomGen.Next(255), randomGen.Next(255), randomGen.Next(255), 255) / 255;

        GameObject pickupClone = Instantiate(ball);

        balls.Add(new Ball(pickupClone, wordPosition, initColor));
    }

    private void OnRightClick()
    {
        foreach (Ball ball in balls)
        {
            // Debug.Log(ball.ToString());
            if (ball.IsSelected())
            {
                //ball.AddForce(new Vector2(100f, 300f));
                //ball.SetInitColor();
                //Debug.Assert(!ball.IsSelected());
            }
        }
    }
}

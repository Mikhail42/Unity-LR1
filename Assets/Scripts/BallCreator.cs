using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public static readonly float CAMERA_Z = 10f;
    private static readonly System.Random randomGen = new System.Random();

    public Rigidbody2D ballRb2d;

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
        // I don't know how to awoid bugs otherwise.
        wordPosition.z = -0.1f;

        Color initColor = new Color(randomGen.Next(255), randomGen.Next(255), randomGen.Next(255), 255) / 255;
        Rigidbody2D ballRb2dClone = Instantiate(ballRb2d, wordPosition, new Quaternion());
        ballRb2dClone.transform.localScale = new Vector3(1f, 1f, 1f)  * (float)(randomGen.NextDouble() + 0.5);
        balls.Add(new Ball(ballRb2dClone, initColor));
    }

    private void OnRightClick()
    {
        foreach (Ball ball in balls)
        {
            if (ball.IsSelected())
            {
                ball.AddForce(new Vector2(0f, 3000f));
                ball.SetInitColor();
            }
        }
    }
}

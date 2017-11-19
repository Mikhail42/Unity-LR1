using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public static readonly float CAMERA_Z = 10f;

    public GameObject pickup;

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

        GameObject pickupClone = Instantiate(pickup);
        pickupClone.transform.SetPositionAndRotation(wordPosition, new Quaternion());
        pickupClone.SetActive(true);

        Ball ball = new Ball(pickupClone);
        balls.Add(ball);
    }

    private void OnRightClick()
    {
        foreach (Ball ball in balls)
        {
            // Debug.Log(ball.ToString());
            if (ball.IsSelected())
            {
                ball.AddForce(new Vector2(100f, 300f));
                ball.SetInitColor();
            }
        }
    }
}

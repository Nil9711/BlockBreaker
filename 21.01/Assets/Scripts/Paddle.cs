using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float leftLimitPaddle = 1.6f;
    [SerializeField] float rightLimitPaddle = 14.4f;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		
        Vector2 paddlePos = new Vector2(transform.position.y, transform.position.y);

        paddlePos.x = Mathf.Clamp(mousePosInUnits, leftLimitPaddle, rightLimitPaddle);
		
        transform.position = paddlePos;

    }
}

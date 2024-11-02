using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public float xySpeed;
    public int xDirection;
    public int yDirection;
    private Transform _ComponentTransform;
    private SpriteRenderer _ComponentSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        _ComponentTransform = GetComponent<Transform>();
        _ComponentSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _ComponentTransform.position = new Vector2(_ComponentTransform.position.x+xySpeed*xDirection*Time.deltaTime,
            _ComponentTransform.position.y+xySpeed*yDirection*Time.deltaTime);
        if (_ComponentTransform.position.x >= 9.15)
        {
            xDirection = -1;
            _ComponentSpriteRenderer.flipX = true;
        }
        else if (_ComponentTransform.position.y >= 8.77)
        {
            yDirection = -1;
            _ComponentSpriteRenderer.flipY = false;
        }
        else if (_ComponentTransform.position.x <= -7.22)
        {
            xDirection = 1;
            _ComponentSpriteRenderer.flipX = false;
        }
        else if (_ComponentTransform.position.y <= -8.81)
        {
            yDirection = 1;
            _ComponentSpriteRenderer.flipY = true;
        }
    }
}

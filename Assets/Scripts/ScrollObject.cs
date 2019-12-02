using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float startPosition;
    [SerializeField] float endPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (transform.position.y <= endPosition)
        {
            transform.Translate(0, -(endPosition - startPosition), 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        // MUST MULTIPLY BY LOCALSCALE SINCE TRANSFORM SCALE HAS BEEN CHANGED (DOESN'T AUTOMATICALLY SCALE BOX COLLIDER CORRESPONDINGLY)
        repeatWidth = GetComponent<BoxCollider>().size.x * transform.localScale.x / 2; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth) {
            transform.position = startPos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchScript : MonoBehaviour
{
    public GameObject touchTextNoticeMoved;
    public GameObject touchTextNoticeStationary;
    public GameObject touchTextNoticeBegan;
    public GameObject touchTextNoticeOneFinger;
    public GameObject touchTextNoticeTwoFingers;
    public GameObject touchTextNoticeThreeFingers;

    // Start is called before the first frame update
    void Start()
    {

    }

    private Quaternion rotationZ;
    private float rotationmodify = 0.1f;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch current_position_touch = Input.GetTouch(0);
            if (current_position_touch.phase == TouchPhase.Moved)
            {
                rotationZ = Quaternion.Euler(-current_position_touch.deltaPosition.x * rotationmodify, 0f, 0f);
                transform.rotation = rotationZ * transform.rotation;
            }
        }
    }
}

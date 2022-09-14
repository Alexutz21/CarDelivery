using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    // this things position (camera) should be the same as the car's position
    //serializam GameObject thingToFollow ca sa il avem in Unity Inspector
    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}

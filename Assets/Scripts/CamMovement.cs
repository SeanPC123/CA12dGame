using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    [SerializeField] private Transform Character;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Character.position.x, transform.position.y, transform.position.z);
    }
}

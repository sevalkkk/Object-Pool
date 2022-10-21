using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private void Update()
    {
        transform.position += moveSpeed * transform.forward * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public int moveSpeed = 3;
    int direction = 1;
    Vector3 position;

    // Update is called once per frame
    void Update()
    {
        position.x = direction * moveSpeed * Time.deltaTime;
        transform.Translate(position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        direction = direction * -1;
    }
}

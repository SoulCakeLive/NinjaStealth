using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] float timer = 3f;

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            var position = new Vector3(transform.position.x, Random.Range(-5f, 5f), 0);
            Instantiate(bullet, position, Quaternion.identity);
            timer = 5f;
        }
    }
}

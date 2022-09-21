using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
    float speed = 3f;
    private float distance;
    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position) * .75f;
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Delete")
        {
            Destroy(gameObject);
        }
    }
}

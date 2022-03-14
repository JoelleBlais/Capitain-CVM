using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAttack : EnnemyBehaviour
{
    public Transform player, shootPos;
    public float range, timeShoot, shootSpeed;
    private float distToPlayer;
    public GameObject bullet;
    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer <= range)
        {
            if (canShoot)
            {
                Attack();
                canShoot = false;
            }
        }

    }

    void Attack()
    {
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0f);
    }


}

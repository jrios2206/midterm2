using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate = 0.3f; // seconds between shots
    private float nextFire = 0.3f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) & Time.time >= nextFire)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            nextFire = Time.time + fireRate; //pum rate of fire
        }
    }
}
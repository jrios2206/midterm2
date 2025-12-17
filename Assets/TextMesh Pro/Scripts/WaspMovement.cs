using UnityEngine;

public class WaspMovement : MonoBehaviour
{
    public float speed = 2f; // hopefully this shit works... oh well it worsk but now goes backwards..
    public float range = .5f;
    public float waveSpeed = 2f;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + speed * Time.deltaTime;
        float y = startPos.y + Mathf.Sin(Time.time * waveSpeed) * range;
        transform.position = new Vector3(x, y, startPos.z);
    }
}

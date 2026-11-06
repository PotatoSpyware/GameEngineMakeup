using UnityEngine;

public class TailTimer : MonoBehaviour
{
    int time;
    float timer;
    float moveTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = PlayerSingle.getInstance().tailLength;
        moveTime = PlayerSingle.getInstance().moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > moveTime)
        {
            time--;
            timer = 0;
        }
        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }
}

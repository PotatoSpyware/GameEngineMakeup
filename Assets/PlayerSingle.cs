using UnityEngine;

public class PlayerSingle : MonoBehaviour
{
    public static PlayerSingle instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    [SerializeField] BoxCollider2D col;
    [SerializeField] GameObject MainMenu;

    public int tailLength = 2;
    public float moveTime = 0.75f;
    private float timer = 0f;
    private Vector3 dir = new Vector2 (0, 0.5f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            dir = new Vector2(0, 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            dir = new Vector2(0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            dir = new Vector2(0, -0.5f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            dir = new Vector2(-0.5f, 0);
        }
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer > moveTime)
        {
            this.gameObject.transform.position += dir;
            timer = 0f;
        }
    }

    public static PlayerSingle getInstance()
    {
        return instance;
    }

    private void setInstance(PlayerSingle inst)
    {
        instance = inst;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Apple")
        {
            Die();
        }
        else
        {
            tailLength++;
        }
    }

    private void Die()
    {
        Time.timeScale = 0f;
        MainMenu.gameObject.SetActive(true);
    }
}

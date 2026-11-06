using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] GameObject tail;
    [SerializeField] GameObject apple;

    public void Spawn(string name)
    {
        if (name == "tail")
        {
            Instantiate(tail, PlayerSingle.getInstance().gameObject.transform, true);
        }

        else if (name == "apple")
        {
            Vector3 pos = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4));
            Quaternion rot = new Quaternion();
            Instantiate(apple, pos, rot);
        }
    }
}

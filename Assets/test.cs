using UnityEngine;

public class test : MonoBehaviour
{
    Vector3 initPos = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = initPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
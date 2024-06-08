public class test : MonoBehaviour
{
    Vector3 initPos = new Vector3(0, 10, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0.1f, 0, 0);
    }
}
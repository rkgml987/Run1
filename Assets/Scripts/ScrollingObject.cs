using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 100f;
    // Update is called once per frame
    private void Update()
    {
        if (!GameManager.instance.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallControllerLevelTwo : MonoBehaviour
{
    private int count;
    public float speed;
    private Rigidbody rb;
    public Text countText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 3;
        count = 0;
        countText.text = "Points: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count++;
        countText.text = "Points: " + count.ToString();

        if (count == 8)
        {
            SceneManager.LoadScene("LevelOne");
        }
    }
}

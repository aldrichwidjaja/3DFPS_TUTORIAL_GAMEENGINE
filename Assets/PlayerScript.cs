using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    bool dangerous;
    AudioSource asound;
    public AudioSource pickup;
    public Camera fcamera;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "weapon1")
        {
            dangerous = true;
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x = 0f;
            rotationVector.y = -90f;
            rotationVector.z = 0f;
            print("got weapon!");
            other.transform.parent = this.transform;

            other.transform.rotation = Quaternion.Euler(rotationVector);
            other.transform.localPosition = new Vector3(0.15f, 0.30f, 0.13f);

            pickup.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            // this is our game over condition
            SceneManager.LoadScene("New Scene 1");
        }
    }

    void Start()
    {
        dangerous = false;
        asound = GetComponent<AudioSource>();
    }

    void Update()
    {
        Debug.DrawRay(fcamera.transform.position, transform.forward * 1000, Color.white);

        if (dangerous == true && Input.GetButtonDown("Fire1"))
        {
            asound.Play();

            fcamera.GetComponent<ShootScript>().Shoot(100000f);
        }
    }
}

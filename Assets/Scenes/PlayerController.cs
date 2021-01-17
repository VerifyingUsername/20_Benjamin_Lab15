using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject jumpText;
    public AudioClip[] AudioClipArr;

    private float jump = 5.0f;

    public Rigidbody playerRb;

    private int jumpCounter;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpCounter++;

            jumpText.GetComponent<Text>().text = "Jump: " + jumpCounter;

            playerRb.AddForce(new Vector3(0, 250, 0));

            //audioSource.Play();
            int rand = Random.Range(0, AudioClipArr.Length);
            audioSource.PlayOneShot(AudioClipArr[rand]);
        }
    }
}

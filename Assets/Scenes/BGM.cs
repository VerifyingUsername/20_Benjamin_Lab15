using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioClip[] BGMclipArr;

    private AudioSource bgmSource;
    // Start is called before the first frame update
    void Start()
    {
        bgmSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        bgm();

        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bgmSource.volume += 0.1f * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            bgmSource.volume -= 0.1f * Time.deltaTime;
        }
    }

    private void bgm ()
    {
        int rand = Random.Range(0, BGMclipArr.Length);
        bgmSource.PlayOneShot(BGMclipArr[rand]);
    }
}

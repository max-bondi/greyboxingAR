using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource myAudioSource;
    string buttonName;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                buttonName = hit.transform.name;
                PlaySound(buttonName);
            }
        }



    }

    void PlaySound(string buttonName)
    {
        switch (buttonName)
        {
            case "AssistedSuicide":
                myAudioSource.clip = audioClips[0];
                myAudioSource.Play();
                break;
            case "CHINA":
                myAudioSource.clip = audioClips[1];
                myAudioSource.Play();
                break;
            case "clothingCulture":
                myAudioSource.clip = audioClips[2];
                myAudioSource.Play();
                break;
            case "SELECTIONS FROM GANDHI":
                myAudioSource.clip = audioClips[3];
                myAudioSource.Play();
                break;
            case "JAPAN":
                myAudioSource.clip = audioClips[4];
                myAudioSource.Play();
                break;
            case "cartoon":
                myAudioSource.clip = audioClips[5];
                myAudioSource.Play();
                break;
        }
    }
}

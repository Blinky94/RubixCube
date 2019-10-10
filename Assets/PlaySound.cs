using UnityEngine;

public class PlaySound : RotationSeries 
{
    AudioSource soundCube;

	void Start ()
    {
        soundCube = GetComponent<AudioSource>();
        soundCube.mute = true;
	}


	void Update () 
    {
        System.Random random = new System.Random();
        int rnd = random.Next(0, 3);

        soundCube.pitch = (float)rnd;
        soundCube.mute = true;
        if (rotating)
        {
            soundCube.mute = false;

        }  
        else
            soundCube.Play();   
	}
}

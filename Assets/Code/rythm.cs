using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rythm : MonoBehaviour
{
    //l�tens beat per minute.
    public float SongBpm;

    //m�ngden av sekunder f�r varje l�t.
    public float SecPerBeat;

    //Var vi ligger i l�ten i sekunder
    public float SongPosition;

    //Current song position, in beats
    public float SongPositionInBeats;

    //How many seconds have passed since the song started
    public float DspSongTime;

    //an AudioSource attached to this GameObject that will play the music.
    public AudioSource MusicSource;


    void Start()
    {
        //Load the AudioSource attached to the Conductor GameObject
        MusicSource = GetComponent<AudioSource>();

        //Calculate the number of seconds in each beat
        SecPerBeat = 60f / SongBpm;

        //Record the time when the music starts
        DspSongTime = (float)AudioSettings.dspTime;

        //Start the music
        MusicSource.Play();
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}

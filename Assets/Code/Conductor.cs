using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conductor : MonoBehaviour
{
    //l�tens beat per minute.
    public float SongBpm;

    //m�ngden av sekunder f�r varje l�t.
    public float SecPerBeat;

    //m�ngden av beats per loop
    public float beatsPerLoop;

    //loops som faktiskt loopa.
    public int completedLoops = 0;
        
    public float loopPositionInBeats;

    //Var vi ligger i l�ten i sekunder.
    public float SongPosition;

    //variabel som ska anv�ndas f�r att m�ta positionen av loopen.
    public float loopPositionInAnalog;

    //Var l�ten ligger i beats.
    public float SongPositionInBeats;

    //Hur m�nga sekunder det har g�tt sen l�ten b�rjade.
    public float DspSongTime;

    //en audiosource kopplad till den h�r gameobject som kommer spela musik.
    public AudioSource MusicSource;

    void start()
    {
        if (SongPositionInBeats >= (completedLoops + 1) * beatsPerLoop)
            completedLoops++;
        loopPositionInBeats = SongPositionInBeats - completedLoops * beatsPerLoop;
    }

    void Start()
    {
        //L�ter oss h�mta audiosource hit.
        MusicSource = GetComponent<AudioSource>();

        //hur m�nge sekunder i varje beat.
        SecPerBeat = 60f / SongBpm;

        //spelar in n�r l�ten b�rjar
        DspSongTime = (float)AudioSettings.dspTime;

        //Startar musiken
        MusicSource.Play();
    }
 

    // Update is called once per frame
    void Update()
    {  //hur m�nga sekunder det har g�tt sen l�ten b�rjade,
        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        //hur m�nga beats sen l�ten b�rjade.
        SongPositionInBeats = SongPosition / SecPerBeat;

        //m�ter positionen av loopen.
        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;
    }
}
//Efe

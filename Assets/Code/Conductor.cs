using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conductor : MonoBehaviour
{
    //låtens beat per minute.
    public float SongBpm;

    //mängden av sekunder för varje låt.
    public float SecPerBeat;

    //mängden av beats per loop
    public float beatsPerLoop;

    //loops som faktiskt loopa.
    public int completedLoops = 0;
        
    public float loopPositionInBeats;

    //Var vi ligger i låten i sekunder.
    public float SongPosition;

    //variabel som ska användas för att mäta positionen av loopen.
    public float loopPositionInAnalog;

    //Var låten ligger i beats.
    public float SongPositionInBeats;

    //Hur många sekunder det har gått sen låten började.
    public float DspSongTime;

    //en audiosource kopplad till den här gameobject som kommer spela musik.
    public AudioSource MusicSource;

    void start()
    {
        if (SongPositionInBeats >= (completedLoops + 1) * beatsPerLoop)
            completedLoops++;
        loopPositionInBeats = SongPositionInBeats - completedLoops * beatsPerLoop;
    }

    void Start()
    {
        //Låter oss hämta audiosource hit.
        MusicSource = GetComponent<AudioSource>();

        //hur månge sekunder i varje beat.
        SecPerBeat = 60f / SongBpm;

        //spelar in när låten börjar
        DspSongTime = (float)AudioSettings.dspTime;

        //Startar musiken
        MusicSource.Play();
    }
 

    // Update is called once per frame
    void Update()
    {  //hur många sekunder det har gått sen låten började,
        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        //hur många beats sen låten började.
        SongPositionInBeats = SongPosition / SecPerBeat;

        //mäter positionen av loopen.
        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;
    }
}
//Efe

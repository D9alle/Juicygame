using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conductor : MonoBehaviour
{
    //låtens beat per minute.
    public float SongBpm;

    //mängden av sekunder för varje låt.
    public float SecPerBeat;

    public float beatsPerLoop;

    public int completedLoops = 0;

    public float loopPositionInBeats;

    //Var vi ligger i låten i sekunder.
    public float SongPosition;

    public float loopPositionInAnalog;

    public static Conductor instance;

    //Var låten ligger i beats.
    public float SongPositionInBeats;

    //Hur många sekunder det har gått sen låten började.
    public float DspSongTime;

    public float FirstBeatOffSet;

    //en audiosource kopplad till den här gameobject som kommer spela musik.
    public AudioSource MusicSource;

    void start()
    {
        if (SongPositionInBeats >= (completedLoops + 1) * beatsPerLoop)
            completedLoops++;
        loopPositionInBeats = SongPositionInBeats - completedLoops * beatsPerLoop;
    }

    void Awake()
    {
        instance = this;
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
    {
        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        SongPositionInBeats = SongPosition / SecPerBeat;

        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        SongPosition = (float)(AudioSettings.dspTime - DspSongTime - FirstBeatOffSet); 
        
        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;

        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, 360, Conductor.instance.loopPositionInAnalog));
    }
}

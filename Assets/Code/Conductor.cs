using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conductor : MonoBehaviour
{
    //l�tens beat per minute.
    public float SongBpm;

    //m�ngden av sekunder f�r varje l�t.
    public float SecPerBeat;

    public float beatsPerLoop;

    public int completedLoops = 0;

    public float loopPositionInBeats;

    //Var vi ligger i l�ten i sekunder.
    public float SongPosition;

    public float loopPositionInAnalog;

    public static Conductor instance;

    //Var l�ten ligger i beats.
    public float SongPositionInBeats;

    //Hur m�nga sekunder det har g�tt sen l�ten b�rjade.
    public float DspSongTime;

    public float FirstBeatOffSet;

    //en audiosource kopplad till den h�r gameobject som kommer spela musik.
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
    {
        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        SongPositionInBeats = SongPosition / SecPerBeat;

        SongPosition = (float)(AudioSettings.dspTime - DspSongTime);

        SongPosition = (float)(AudioSettings.dspTime - DspSongTime - FirstBeatOffSet); 
        
        loopPositionInAnalog = loopPositionInBeats / beatsPerLoop;

        this.gameObject.transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, 360, Conductor.instance.loopPositionInAnalog));
    }
}

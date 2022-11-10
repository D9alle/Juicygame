using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rythm : MonoBehaviour
{
    //l�tens beat per minute.
    public float SongBpm;

    //m�ngden av sekunder f�r varje l�t.
    public float SecPerBeat;

    //Var vi ligger i l�ten i sekunder.
    public float SongPosition;

    //Var l�ten ligger i beats.
    public float SongPositionInBeats;

    //Hur m�nga sekunder det har g�tt sen l�ten b�rjade.
    public float DspSongTime;

    public float FirstBeatOffSet;

    //en audiosource kopplad till den h�r gameobject som kommer spela musik.
    public AudioSource MusicSource;


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

    }
}

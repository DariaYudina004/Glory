using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]

[CreateAssetMenu (menuName = "Configs/SongItems", fileName = "SongItems")]
public class SongItems : ScriptableObject
{
    [field: SerializeField] public string ID { get; protected set; }

    [field: SerializeField] public AudioSource SongOnStage { get; protected set; }
    [field: SerializeField] public int MoneyAfterSong { get; protected set; }
}

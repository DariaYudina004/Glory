using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Configs/SongItemsConfig", fileName = "SongItemsConfig")]
public class SongItemsConfig : ScriptableObject
{
    public List<SongItems> songItems;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class EventManager : MonoBehaviour
{
    [Header("Player Events")] 
    public UnityEvent<float, GameObject> PlayerDamageEvent = new UnityEvent<float, GameObject>();
    public UnityEvent<GameObject> PlayerDeathEvent = new UnityEvent<GameObject>();
    public UnityEvent LootCollected = new UnityEvent();
    public UnityEvent StartFireEvent = new UnityEvent();
    public UnityEvent StopFireEvent = new UnityEvent();
    public UnityEvent ItemSpawnEvent = new UnityEvent();
    public UnityEvent ItemCollected = new UnityEvent();
    
    [Header("Common Enemy Events")]
    public UnityEvent<GameObject> EnemyDeathEvent = new UnityEvent<GameObject>();
}

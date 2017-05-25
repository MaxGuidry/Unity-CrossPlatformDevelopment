using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerHealthChange : UnityEngine.Events.UnityEvent {}
[System.Serializable]
public class PlayerChangeWithPlayerInfo : UnityEngine.Events.UnityEvent<TestPlayerBehavior.PlayerInfo>{}

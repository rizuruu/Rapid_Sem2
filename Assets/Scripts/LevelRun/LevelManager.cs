using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    [SerializeField] private RandomWalkDungeonGenerator _levelGenerator;
    [SerializeField] private BasePlayer _basePlayer;

    public LevelRunStats levelRunStats;


    override protected void Awake()
    {
        base.Awake();
        levelRunStats = new LevelRunStats();
        _levelGenerator.GenerateDungeon();
    }

    public void ResetLevel()
    {
        _basePlayer.gameObject.SetActive(true);
        _basePlayer.Resurrect();
        levelRunStats.Reset();
        _levelGenerator.GenerateDungeon();
    }
}
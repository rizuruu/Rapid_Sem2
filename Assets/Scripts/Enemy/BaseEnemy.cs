using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BaseEnemy : BaseUnit, IDamageable
{
    [Header("Drop Variables")]
    [SerializeField] private int _minCoinDropRate = 0;
    [SerializeField] private int _maxCoinDropRate = 5;

    protected override void Die()
    {
        base.Die();
        gameObject.SetActive(false);
        LevelRunStats levelStats = LevelManager.instance.levelRunStats;
        levelStats.AddKill();
        levelStats.AddCoins(Random.Range(_minCoinDropRate, _maxCoinDropRate));
    }
}
using System.Collections;
using UnityEngine;
using TheProphecy.LevelRun;
using TheProphecy.Items;
using TheProphecy.Interfaces;
using TheProphecy;

public class ChestInteraction : MonoBehaviour, IInteractable
{

    [SerializeField] private SpriteRenderer _openedChest;
    [SerializeField] private SpriteRenderer _closedChest;
    [SerializeField] private GameObject _healthPickup;
    [SerializeField] private BoxCollider2D _interactableBoxCollider;
    [SerializeField] private BoxCollider2D _noWalkBoxCollider;

    public void OnInteract()
    {
        OpenChest();
    }

    private void OpenChest()
    {
        LevelRunStats levelStats = LevelManager.instance.levelRunStats;
        bool canOpenChest = levelStats.TryToUseKey();


        if (canOpenChest)
        {
            _openedChest.enabled = true;
            _closedChest.enabled = false;
            _interactableBoxCollider.enabled = false;
            StartCoroutine(SpawnHealth());
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Bullet")
        {
            this.OnInteract();
        }
        else if (collider.tag == "Player")
        {
            collider.GetComponent<BasePlayer>().PickupHealth(2);
            Destroy(this.gameObject);
        }
    }

    IEnumerator SpawnHealth()
    {
        yield return new WaitForSeconds(1);
        _openedChest.enabled = false;
        _closedChest.enabled = false;
        _interactableBoxCollider.enabled = false;
        _noWalkBoxCollider.enabled = false ;
        _healthPickup.SetActive(true);
        yield return null;
    }
}

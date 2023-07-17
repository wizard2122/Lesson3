using UnityEngine;

public class EnemySpawnerBootstrap : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;

    private void Awake()
    {
        _spawner.StartWork();
    }
}

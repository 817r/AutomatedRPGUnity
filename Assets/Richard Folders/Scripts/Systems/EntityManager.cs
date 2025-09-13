using UnityEngine;

public class EntityManager : MonoBehaviour
{
    public static EntityManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    [SerializeField] CoreTraitPool[] coreTraits;

    public CoreTrait GetRandomCoreTrait()
    {
        if (coreTraits.Length == 0) return null;
        int poolIndex = Random.Range(0, coreTraits.Length);
        CoreTraitPool selectedPool = coreTraits[poolIndex];
        if (selectedPool.coreTraitsPool.Length == 0) return null;
        int traitIndex = Random.Range(0, selectedPool.coreTraitsPool.Length);
        return selectedPool.coreTraitsPool[traitIndex];
    }
}

using UnityEngine;

public class RecyclingBag : MonoBehaviour
{
    public GameObject[] PossibleItemPrefabs;
    public int SpawnCount;

    private void OnMouseUpAsButton()
    {
        if (PossibleItemPrefabs.Length > 0)
        {
            for (var i = 0; i < SpawnCount; ++i)
            {
                Vector3 Offset = new Vector3(Random.Range(-1.7f, 2.3f), Random.Range(0, 2.3f), 0.0f);

                var randomNum = Random.Range(0, PossibleItemPrefabs.Length);
                Instantiate(PossibleItemPrefabs[randomNum], transform.position + Offset, transform.rotation);
            }
        }

        DestroyImmediate(gameObject);
    }
}

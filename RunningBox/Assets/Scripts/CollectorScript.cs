using System.Collections;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    int stackAmnt = 0;
    bool canCollect = true;

    [SerializeField]
    float collectTime = 0.2f;
    
    private void OnTriggerStay(Collider other)
    {
        if (canCollect && other.TryGetComponent(out PlayerBag _bag))
        {
            canCollect = false;
            _bag.PopBrickOut(GetStackPosition(stackAmnt), transform);
            stackAmnt++;
            StartCoroutine(collectTimer());
        }
    }

    Vector3 GetStackPosition(int index)
    {
        int x = index % 4;
        int y = index / 20;
        int z = index % 20 / 4;

        Vector3 target = new Vector3(-1.8f + (1.2f * x),
                                     0.3f + (0.5f * y),
                                     2f - (z));
        return target;
    }

    IEnumerator collectTimer()
    {
        yield return new WaitForSeconds(collectTime);
        canCollect = true;
    }
}

using System.Collections.Generic;
using UnityEngine;

public class PlayerBag : MonoBehaviour
{
    
    Stack<Transform> brickStack = new Stack<Transform>();

    [SerializeField]
    Transform carryPoint;

    [SerializeField]
    Transform brickPrefab;

    private void Start()
    {
        for(int i = 0; i < 50; i++)
        {
            Transform spawnedBrick = Instantiate(brickPrefab, carryPoint.position + new Vector3(0, i * 0.5f, 0), Quaternion.identity, transform);
            //brickList.Add(spawnedBrick);
            brickStack.Push(spawnedBrick);
        }
    }

    public void PopBrickOut(Vector3 _target, Transform _newParent)
    {
        if (brickStack.Count != 0)
        {
            Transform _brick = brickStack.Pop();
            _brick.GetComponent<BrickScript>().setTargetPosition(_target, _newParent);
        }
    }
}

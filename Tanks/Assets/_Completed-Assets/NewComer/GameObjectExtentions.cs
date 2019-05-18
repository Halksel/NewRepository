using System.Linq;
using UnityEngine;

public static class GameObjectExtensions
{
    public static T[] GetComponentsInChildrenWithoutSelf<T>(this GameObject self) where T : Component
    {
        return self.GetComponentsInChildren<T>().Where(c => self != c.gameObject).ToArray();
    }
    public static T SafeGetComponent<T>(this GameObject gameObject) where T : Component
    {
        return 
            gameObject.GetComponent<T>() ?? 
            gameObject.AddComponent<T>();
    }
}
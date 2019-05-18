using UnityEngine;

public static class ListExtentions
{
    public static T GetRandomItem<T>(this T[] self)
    {
        return self[Random.Range(0, self.Length)];
    }
}

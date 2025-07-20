using LabApi.Features.Wrappers;
using UnityEngine;
using MEC;

namespace Sized;

public static class Utilities
{
    public static void SetScale(this Player player, Vector3 scale)
    {
        Timing.CallDelayed(Timing.WaitForOneFrame, () => player.Scale = scale);
    }

    public static Vector3 GetRandomScale()
    {
        Vector3 maxScale = Plugin.Instance.Config.MaximumSize;
        Vector3 minScale = Plugin.Instance.Config.MinimumSize;

        float x = Random.Range(minScale.x, maxScale.x);
        float y = Random.Range(minScale.y, maxScale.y);
        float z = Random.Range(minScale.z, maxScale.z);
        return new Vector3(x, y, z);
    }
}
using UnityEngine;

namespace HexCity.Core
{
    [CreateAssetMenu(menuName = "Config/Camera/Strategy Camera")]
    public sealed class CameraConfig : ScriptableObject
    {
        [Header("Pan")]
        public float panSpeed = 30f;

        [Header("Zoom")]
        public float zoomSpeed = 5f;
        public float minZoom = 10f;
        public float maxZoom = 40f;

        [Header("Start")]
        public Vector3 startPosition = new(0f, 25f, -15f);
        public Vector3 startRotation = new(60f, 0f, 0f);
        public float startZoom = 20f;
    }
}

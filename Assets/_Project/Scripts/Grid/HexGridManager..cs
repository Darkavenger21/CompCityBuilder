using UnityEngine;

namespace HexCity.Grid
{
    public sealed class HexGridManager : MonoBehaviour
    {
        [Header("Grid Settings")]
        [SerializeField] private int width = 10;
        [SerializeField] private int height = 10;
        [SerializeField] private float hexRadius = 1f;
        [SerializeField] private GameObject hexPrefab;

        private float hexWidth;
        private float hexHeight;
        private float horizontalSpacing;
        private float verticalSpacing;

        private void Awake()
        {
            hexWidth = hexRadius * 2f;
            hexHeight = Mathf.Sqrt(3f) * hexRadius;

            horizontalSpacing = hexWidth * 0.75f;
            verticalSpacing = hexHeight;
        }

        private void Start()
        {
            GenerateGrid();
        }

        private void GenerateGrid()
        {
            for (int q = 0; q < width; q++)
            {
                for (int r = 0; r < height; r++)
                {
                    Vector3 position = CalculateWorldPosition(q, r);
                    Instantiate(hexPrefab, position, Quaternion.identity, transform);
                }
            }
        }

        private Vector3 CalculateWorldPosition(int q, int r)
        {
            float x = q * horizontalSpacing;
            float z = r * verticalSpacing + (q % 2 == 0 ? 0f : verticalSpacing / 2f);
            return new Vector3(x, 0f, z);
        }
    }
}

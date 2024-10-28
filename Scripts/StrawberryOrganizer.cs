using UnityEngine;

public class StrawberryOrganizer : MonoBehaviour
{
    [SerializeField] private Transform _strawberryMain;
    private Transform[] _strawberries;
    private void Start()
    {
        _strawberries = new Transform[_strawberryMain.childCount];

        AddStrawberries();
    }

    private void AddStrawberries()
    {
        for (int i = 0; i < _strawberryMain.childCount; i++)
            _strawberries[i] = _strawberryMain.GetChild(i).transform;
    }
}

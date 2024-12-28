using UnityEngine;
using UnityEngine.UIElements;

public class ButtonEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;

    public DataObject gameData;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q("ScavageButton") as Button;
        _button.RegisterCallback<ClickEvent>(OnScavageClicked);
    }

    private void OnScavageClicked(ClickEvent evt)
    {
        Debug.Log("OnScavageClicked");
        gameData.bolts++;
        gameData.nuts += Random.Range(0,3);
    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnScavageClicked);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class QuestAction : MonoBehaviour, IUsable
{
    [SerializeField] private Questor _questor;
    [SerializeField] private Sprite _newSprite;

    private string _questItem;

    private void Awake()
    {
        _questItem = _questor.questItem.nameItem;
    }

    public void CheckUsing()
    {
        if (_questItem == null)
        {
            CompleteAction();
        }
    }
    
    public void CheckUsing(Item item)
    {
        if (_questItem != null && item.nameItem == _questItem)
        {
            CompleteAction();
        }
    }

    private void CompleteAction()
    {
        if (!_questor.questIsDone)
        {
            _questor.CompleteAction();

            if (_newSprite != null)
            {
                GetComponent<SpriteRenderer>().sprite = _newSprite;
            }
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _textObject;
    [SerializeField] private List<string> _states = new List<string>();

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.AppendCallback(() =>
        {
            _textObject.text = "";
        });

        foreach (string state in _states)
        {
            int method = Random.Range(0, 3);

            switch (method)
            {
                case 0:
                    sequence.AppendCallback(() =>
                    {
                        _textObject.text = state;
                    });
                    break;

                case 1:
                    sequence.AppendCallback(() =>
                    {
                        _textObject.text += "\n" + state;
                    });
                    break;

                case 2:
                    sequence.Append(
                        _textObject.DOText(
                            state,
                            3f,
                            true,
                            ScrambleMode.All
                        )
                    );
                    break;
            }

            sequence.AppendInterval(2f);
        }

        sequence.SetLoops(-1, LoopType.Restart);
    }
}

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

        foreach (string state in _states)
        {
            int method = Random.Range(0, 3);

            switch (method)
            {
                case 0:
                    sequence.Append(
                        _textObject.DOText(state, 3f)
                    );
                    break;

                case 1:
                    sequence.Append(
                        _textObject.DOText(
                            _textObject.text + "\n" + state,
                            3f
                        )
                    );
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

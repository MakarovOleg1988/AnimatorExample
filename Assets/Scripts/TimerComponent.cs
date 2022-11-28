using UnityEngine;
using UnityEngine.UI;

namespace AnimatorExample
{
    public class TimerComponent : MonoBehaviour
    {
        public Text _text;
        public Animator _animator;
        [SerializeField, Range(10, 20)] protected int time;
    }
}

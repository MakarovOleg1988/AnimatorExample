using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace AnimatorExample
{
    public class TimerAssistant : TimerComponent
    {
        private void OnValidate()
        {
            _text = GetComponent<Text>();
            _animator = GetComponent<Animator>();
        }

        private void Start()
        {
            _text.text = time.ToString(); 
            StartCoroutine(Timer());
        }

        private IEnumerator Timer()
        {
            while (time > 0)
            {
                _text.text = time.ToString();
                time--;
                yield return new WaitForSeconds(1f);

                _animator.SetTrigger(time > 5 ? "TimerExample" : "TimerExample2");
                yield return new WaitForSeconds(1f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TittleFade : MonoBehaviour
{
    [SerializeField] float _waitsecond;//�A�j���[�V�����ɂ�炸�҂b��
    public void TitleLoad(string name)
    {
        StartCoroutine(LoadScene(name));
    }
    public IEnumerator LoadScene(string name)
    {
        //��Ŏg��
        //yield return new WaitUntil(() => Triger._canFadeOut);//�t�F�[�h����摜�̕���Bool��true�ɂȂ�Ȃ����肱���ő҂��Ă����
        yield return new WaitForSeconds(_waitsecond);//�A�j���[�V�������I�������w�肵���b���҂��Ă����
        SceneManager.LoadScene(name);
    }
}

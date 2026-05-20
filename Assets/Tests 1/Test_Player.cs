using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test_Player : InputTestFixture
{
    private Mouse mouse;
    [SetUp]
    public override void Setup()
    {
        base.Setup();
        SceneManager.LoadScene("HomePlay");
        mouse = InputSystem.AddDevice<Mouse>();
    }
    
    [UnityTest]
    public IEnumerator test_()
    {
        

        var button = GameObject.FindWithTag("playgame");
        Debug.Log(button);

        var scence_name = SceneManager.GetActiveScene().name;
        Debug.Log(scence_name);
        
        Assert.That(scence_name, Is.EqualTo("HomePlay"), "failed");
        TestButton(button);

        yield return new WaitForSeconds(2f);

        scence_name = SceneManager.GetActiveScene().name;
        Debug.Log(scence_name);

        Assert.That(scence_name, Is.EqualTo("HomePlay"));

    }

    [UnityTest]
    public IEnumerator Testcongdiem()
    {
        var gameoj = new GameObject();
        var testcong = gameoj.AddComponent<Player>();
        testcong.congdiem(2);
        yield return null;
        Assert.AreEqual(5, testcong.countdow);
        
        Debug.Log(testcong.countdow);
    }
    
    [UnityTest]
    public IEnumerator Testdiem()
    {
        var gameoj = new GameObject();
        var testtru = gameoj.AddComponent<Player>();
        testtru.trudiem(2);
        yield return null;
        Assert.AreEqual(1, testtru.countdow);
        
        Debug.Log(testtru.countdow);
    }

    public void TestButton(GameObject buttonn)
    {
        var buttonz = buttonn.GetComponent<Button>();

        if (buttonz != null)
        {
            buttonz.onClick.Invoke();
        }
        else
        {
            Debug.Log("Button not found");
        }
    }
    
}
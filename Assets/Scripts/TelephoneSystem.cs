using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelephoneSystem : MonoBehaviour
{
    private Transform _panel;
    private Text _text;
    [SerializeField] private string[,] _messages= { {"Busca un documento en el que puedas encontrar información para superar la prueba.\nRecuerda que en tu mochila táctica tienes un conjunto de objetos y herramientas que \n te pueden ser muy útiles.", "Proba gainditzeko beharrezkoa den informazioa aurkituko duzun dokumentua bilatu.\nGogoratu zure motxila taktikoan erabilgarriak izan ahal diren objektuak eta tresnak dituzula." },
        {"Parece que no puedes acceder a la segunda puerta. Busca en la mochila algún recurso, pero\npiensa muy bien qué objeto es el más idóneo.", "Badirudi bigarren atera ezin zarela sartu. Bilatu motxilan edozein baliabide, baina oso ondo\npentstau zein den tresnarik egokiena." },
        {"Para poder desbloquear la tercera puerta…ups, parece que se corta la conexión. Parece que\nla batería de tu móvil está fallando ¡rápido! busca algo con lo que puedas reanudar la conexión.", "-Hirugarren atea irekitzeko...ups, konexioa mozten dela dirudi. Zure mugikorreko bateria\nagortzen ari da, azkar! Konexioa berreskuratu ahal izateko zerbait bilatu." },
        {"Busca una caja en esta zona, contiene el código para entrar dentro del edificio del supercomputador","Bilatu kutxa bat eremu honetatik, superordenagailuaren eraikuntzaren barrura sartzeko kodea dauka" } ,
        {"Ese logo de DARKNESS parece sospechoso, podría contener alguna pista para acceder a su ordenador" ,"DARKNESS-en logo hori susmagarria dirudi, bere ordenagailura sartzeko pista eduki ahal du"},
        {"¡Enhorabuena! has conseguido llegar hasta el potente ordenador central de DARKNESS. Esta\nes la parte más delicada de tu misión. En primer lugar, conecta al ordenador el pen drive que\nencontrarás en tu mochila. Después, escapa utilizando el helicóptero","!!Zorionak!! DARKNESS-eko ordenagailu zentral indartsura iristea lortu duzu. Hau da zure misioaren zatirik delikatuena. Lehenik eta behin, konektatu zure motxilan aurkituko duzun pen drive-a ordenagailura. Ondoren, ihes egin helikopteroa erabiliz" } } ;


    private int _actualMessage = 0;
    private float _timer = 0;
    [SerializeField] private float _maxTimer = 10;
    private float _timer2 = 0;
    private float _maxTimer2 = 2;
    private int _soundCount =5;
    [SerializeField] private AudioClip _telephoneSound;
    private int _actualHero=0;
    [SerializeField] private GameObject[] _heroes;

    private OptionScriptable _optionScriptable;
    private void Awake()
    {
        _optionScriptable = Resources.Load<OptionScriptable>("Options");
        if (transform.childCount != 0)
        {
            _panel = transform.GetChild(0);
        }
        _text = _panel.GetComponentInChildren<Text>();
    }

    private void Start()
    {
        _text.text = _messages[0,_optionScriptable.languagueId];
    }

    private void Update()
    {
        if (_timer <= 0)
        {
            _panel.gameObject.SetActive(false);
            return;
        }
        _timer -= Time.deltaTime;
        if (_timer2 <= 0 && _soundCount>0)
        {
            _timer2 = _maxTimer2;
            _soundCount--;
            SoundEmitter.Instance().PlaySFX(_telephoneSound);
            return;
        }
        _timer2 -= Time.deltaTime;
    }

    public void newCall()
    {
        _timer = _maxTimer;
        _text.text = _messages[_actualMessage, _optionScriptable.languagueId];
        _panel.gameObject.SetActive(true);
        _soundCount = 5;
    }

    public void nextMessage()
    {
        _actualMessage++;
        _text.text = _messages[_actualMessage,_optionScriptable.languagueId];
        _actualHero++;
        _actualHero %= _heroes.Length;
        for (int i = 0; i < _heroes.Length; i++) 
        {
            _heroes[i].SetActive(false);
            if (i == _actualHero)
            {
                _heroes[i].SetActive(true);
            }
        }
        

    }
}

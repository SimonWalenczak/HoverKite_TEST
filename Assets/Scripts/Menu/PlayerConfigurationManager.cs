using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerConfigurationManager : MonoBehaviour
{
    [HideInInspector] public List<PlayerConfiguration> playerConfigs;
    [SerializeField] private int MaxPlayer = 2;
    [SerializeField] private bool SelecteionFinish;
    public static PlayerConfigurationManager Instance { get; private set; }
    [SerializeField] private GameObject TransitionObject;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There is already another PlayerConfigurationManager in this scene !");
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
            playerConfigs = new List<PlayerConfiguration>();
        }

        MaxPlayer = GameData.NumberOfPlayer;
    }

    private void Update()
    {
        if (SelecteionFinish == false)
        {
            if (playerConfigs.Count >= MaxPlayer)
            {
                GetComponent<PlayerInputManager>().playerPrefab = null;
                SelecteionFinish = true;
            }
        }
    }

    public List<PlayerConfiguration> GetPlayerConfigs()
    {
        return playerConfigs;
    }

    public void SetPlayerMesh(int index, GameObject mesh, int intMesh)
    {
        playerConfigs[index].MeshPlayer = mesh;
        playerConfigs[index].MeshIndex = intMesh;
        playerConfigs[index].NumPlayer = playerConfigs[index].PlayerIndex;
    }

    public void ReadyPlayer(int index)
    {
        playerConfigs[index].IsReady = true;
        if (playerConfigs.Count == MaxPlayer && playerConfigs.All(p => p.IsReady == true))
        {
            StartCoroutine(Transition());
        }
    }

    public void HandlePlayerJoin(PlayerInput pi)
    {
        if (playerConfigs.Count < MaxPlayer)
        {
            Debug.Log("Player Joined " + pi.playerIndex);

            if (playerConfigs.All(p => p.PlayerIndex != pi.playerIndex))
            {
                pi.transform.SetParent(transform);
                playerConfigs.Add(new PlayerConfiguration(pi));
            }
        }
        else
        {
            Debug.Log("Max Player");
        }
    }

    IEnumerator Transition()
    {
        TransitionObject.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("FakeMovement");
    }
}

public class PlayerConfiguration
{
    public PlayerConfiguration(PlayerInput pi)
    {
        PlayerIndex = pi.playerIndex;
        Input = pi;
    }

    public PlayerInput Input { get; set; }
    public int PlayerIndex { get; set; }
    public bool IsReady { get; set; }
    
    public Color ColorPlayer { get; set; }
    public GameObject MeshPlayer { get; set; }
    public int MeshIndex { get; set; }
    public int NumPlayer { get; set; }
}
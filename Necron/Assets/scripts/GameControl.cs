using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText, redMText, redEText, redHText, yellowMText, yellowEText, yellowHText, blackText, greenMText, greenEText, greenHText, whiteText, blueMText, blueEText, blueHText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");
        redMText = GameObject.Find("RedMText");
        redEText = GameObject.Find("RedEText");
        redHText = GameObject.Find("RedHText");
        greenMText = GameObject.Find("GreenMText");
        greenEText = GameObject.Find("GreenEText");
        greenHText = GameObject.Find("GreenHText");
        yellowMText = GameObject.Find("YellowMText");
        yellowEText = GameObject.Find("YellowEText");
        yellowHText = GameObject.Find("YellowHText");
        blueMText = GameObject.Find("BlueMText");
        blueEText = GameObject.Find("BlueEText");
        blueHText = GameObject.Find("BlueHText");
        blackText = GameObject.Find("BlackText");
        whiteText = GameObject.Find("WhiteText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        greenMText.gameObject.SetActive(false);
        greenEText.gameObject.SetActive(false);
        greenHText.gameObject.SetActive(false);
        yellowEText.gameObject.SetActive(false);
        yellowMText.gameObject.SetActive(false);
        yellowHText.gameObject.SetActive(false);
        redMText.gameObject.SetActive(false);
        redEText.gameObject.SetActive(false);
        redHText.gameObject.SetActive(false);
        blackText.gameObject.SetActive(false);
        blueMText.gameObject.SetActive(false);
        blueEText.gameObject.SetActive(false);
        blueHText.gameObject.SetActive(false);
        whiteText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
            greenMText.gameObject.SetActive(false);
            greenEText.gameObject.SetActive(false);
            greenHText.gameObject.SetActive(false);
            yellowEText.gameObject.SetActive(false);
            yellowMText.gameObject.SetActive(false);
            yellowHText.gameObject.SetActive(false);
            redMText.gameObject.SetActive(false);
            redEText.gameObject.SetActive(false);
            redHText.gameObject.SetActive(false);
            blackText.gameObject.SetActive(false);
            blueMText.gameObject.SetActive(false);
            blueEText.gameObject.SetActive(false);
            blueHText.gameObject.SetActive(false);
            whiteText.gameObject.SetActive(false);
            if (player1StartWaypoint == 1 || player1StartWaypoint == 23 || player1StartWaypoint == 45 || player1StartWaypoint == 68)
            {
                redMText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 2 || player1StartWaypoint == 24 || player1StartWaypoint == 46 || player1StartWaypoint == 69)
            {
                yellowMText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 3 || player1StartWaypoint == 25 || player1StartWaypoint == 47)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 4 || player1StartWaypoint == 26 || player1StartWaypoint == 48)
            {
                greenMText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 5 || player1StartWaypoint == 27 || player1StartWaypoint == 49 || player1StartWaypoint == 50)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().moveAllowed = false;
            }
            if (player1StartWaypoint == 6 || player1StartWaypoint == 28 || player1StartWaypoint == 51)
            {
                blueMText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 7 || player1StartWaypoint == 29 || player1StartWaypoint == 52)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 8 || player1StartWaypoint == 30 || player1StartWaypoint == 53)
            {
                redHText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 9 || player1StartWaypoint == 31 || player1StartWaypoint == 54)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().moveAllowed = false;
            }
            if (player1StartWaypoint == 10 || player1StartWaypoint == 32 || player1StartWaypoint == 55)
            {
                blueEText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 12 || player1StartWaypoint == 34 || player1StartWaypoint == 57)
            {
                greenEText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 13 || player1StartWaypoint == 35 || player1StartWaypoint == 58)
            {
                yellowHText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 14 || player1StartWaypoint == 36 || player1StartWaypoint == 59)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().moveAllowed = false;
            }
            if (player1StartWaypoint == 15 || player1StartWaypoint == 37 || player1StartWaypoint == 60)
            {
                redEText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 16 || player1StartWaypoint == 38 || player1StartWaypoint == 61)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 17 || player1StartWaypoint == 39 || player1StartWaypoint == 62)
            {
                blueHText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 18 || player1StartWaypoint == 40 || player1StartWaypoint == 63)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                player2.GetComponent<FollowThePath>().moveAllowed = false;
            }
            if (player1StartWaypoint == 19 || player1StartWaypoint == 41 || player1StartWaypoint == 64)
            {
                greenHText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 20 || player1StartWaypoint == 42 || player1StartWaypoint == 65)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player1StartWaypoint == 21 || player1StartWaypoint == 43 || player1StartWaypoint == 66)
            {
                yellowEText.gameObject.SetActive(true);
            }
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
            greenMText.gameObject.SetActive(false);
            greenEText.gameObject.SetActive(false);
            greenHText.gameObject.SetActive(false);
            yellowEText.gameObject.SetActive(false);
            yellowMText.gameObject.SetActive(false);
            yellowHText.gameObject.SetActive(false);
            redMText.gameObject.SetActive(false);
            redEText.gameObject.SetActive(false);
            redHText.gameObject.SetActive(false);
            blackText.gameObject.SetActive(false);
            blueMText.gameObject.SetActive(false);
            blueEText.gameObject.SetActive(false);
            blueHText.gameObject.SetActive(false);
            whiteText.gameObject.SetActive(false);
            if (player2StartWaypoint == 1 || player2StartWaypoint == 23 || player2StartWaypoint == 45 || player2StartWaypoint == 68)
            {
                redMText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 2 || player2StartWaypoint == 24 || player2StartWaypoint == 46 || player2StartWaypoint == 69)
            {
                yellowMText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 3 || player2StartWaypoint == 25 || player2StartWaypoint == 47)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 4 || player2StartWaypoint == 26 || player2StartWaypoint == 48)
            {
                greenMText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 5 || player2StartWaypoint == 27 || player2StartWaypoint == 49 || player2StartWaypoint == 50)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player2.GetComponent<FollowThePath>().moveAllowed = true;
            }
            if (player2StartWaypoint == 6 || player2StartWaypoint == 28 || player2StartWaypoint == 51)
            {
                blueMText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 7 || player2StartWaypoint == 29 || player2StartWaypoint == 52)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 8 || player2StartWaypoint == 30 || player2StartWaypoint == 53)
            {
                redHText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 9 || player2StartWaypoint == 31 || player2StartWaypoint == 54)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player2.GetComponent<FollowThePath>().moveAllowed = true;
            }
            if (player2StartWaypoint == 10 || player2StartWaypoint == 32 || player2StartWaypoint == 55)
            {
                blueEText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 12 || player2StartWaypoint == 34 || player2StartWaypoint == 57)
            {
                greenEText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 13 || player2StartWaypoint == 35 || player2StartWaypoint == 58)
            {
                yellowHText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 14 || player2StartWaypoint == 36 || player2StartWaypoint == 59)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player2.GetComponent<FollowThePath>().moveAllowed = true;
            }
            if (player2StartWaypoint == 15 || player2StartWaypoint == 37 || player2StartWaypoint == 60)
            {
                redEText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 16 || player2StartWaypoint == 38 || player2StartWaypoint == 61)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 17 || player2StartWaypoint == 39 || player2StartWaypoint == 62)
            {
                blueHText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 18 || player2StartWaypoint == 40 || player2StartWaypoint == 63)
            {
                whiteText.gameObject.SetActive(true);
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player2.GetComponent<FollowThePath>().moveAllowed = true;
            }
            if (player2StartWaypoint == 19 || player2StartWaypoint == 41 || player2StartWaypoint == 64)
            {
                greenHText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 20 || player2StartWaypoint == 42 || player2StartWaypoint == 65)
            {
                blackText.gameObject.SetActive(true);
            }
            if (player2StartWaypoint == 21 || player2StartWaypoint == 43 || player2StartWaypoint == 66)
            {
                yellowEText.gameObject.SetActive(true);
            }
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }
    
}

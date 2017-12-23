using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic
{
    public class BeSocialGameController
    {
        private LinkedList<ISocialMission> m_MissionsLinkedList = new LinkedList<ISocialMission>();
        private LinkedListNode<ISocialMission> m_CurrentMissionNode;

        public LinkedListNode<ISocialMission> CurrentMissionNode
        {
            get { return m_CurrentMissionNode; }
        }

        public ISocialMission CurrentMission
        {
            get { return CurrentMissionNode.Value; }
        }

        public GameModel Model { get; set; }

        public int PlayerScore { get; set; }

        public int MaxScore { get; }

        public BeSocialGameController(GameModel i_Model)
        {
            PlayerScore = 0;
            MaxScore = 10;
            Model = i_Model;
            initializeAllMissions();
            m_CurrentMissionNode = m_MissionsLinkedList.First;
        }

        private void initializeAllMissions()
        {
            List<ISocialMission> tempMissionList = new List<ISocialMission>();

            tempMissionList.Add(new MissionShareALink(Model));
            tempMissionList.Add(new MissionTagAFriendAndShareALink(Model));
            tempMissionList.Add(new MissionTagFriendAndPost(Model));
            tempMissionList.Add(new MissionUploadPhoto(Model));
            tempMissionList.Add(new MissionWriteALongPost(Model));
            tempMissionList.Add(new MissionWriteAPost(Model));

           randomizeMissionsOrder(tempMissionList);
        }

        private void randomizeMissionsOrder(List<ISocialMission> i_TempList)
        {
            Random rand = new Random();
            ISocialMission mission;
            int n = i_TempList.Count;
            while (n > 1)
            {
                n--;
                int i = rand.Next(n + 1);
                mission = i_TempList[i];
                i_TempList[i] = i_TempList[n];
                i_TempList[n] = mission;
            }

            foreach (ISocialMission tempMission in i_TempList)
            {
                m_MissionsLinkedList.AddFirst(tempMission);
            }
        }

        public bool IsCurrentMissionFullfilled()
        {
            return CurrentMission.IsFulfilled();
        }

        public void RewardPoints()
        {
            PlayerScore += CurrentMission.ScoreValue;
        }

        public void SkipToNextMission()
        {
            if (m_CurrentMissionNode.Next != null)
            {
                m_CurrentMissionNode = m_CurrentMissionNode.Next;
            }
            else
            {
                m_CurrentMissionNode = null;
            }
        }

        public void ResetGame()
        {
            PlayerScore = 0;
            List<ISocialMission> tempMissionList = new List<ISocialMission>();
            foreach(ISocialMission mission in m_MissionsLinkedList)
            {
                tempMissionList.Add(mission);
            }

            randomizeMissionsOrder(tempMissionList);
            m_CurrentMissionNode = m_MissionsLinkedList.First;
        }

        public bool IsReachedMaxPoints()
        {
            return PlayerScore >= MaxScore;
        }
    }
}

using A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Lior_Yuval
{
    public static class MissionFactory
    {
        /*
         $Lior - notes for bug fixing implementing Factory Method pattern:
         once i moved all the creational methods the following problems were created:
         1. the creational methods can no longer reference to m_MissionsList data member that used to be in the controller
         I need to change the way of referencing "the object that is being created"

         2. In BeSocialController there is a method that resets the missions which uses "randomizeMissions".
         The method has moved to the factory. 
         I need to change the way that they are being referenced (maybe just create a new missions list?)...
         */

        public static LinkedList<ISocialMission> CreateMissionList(GameModel i_Model)
        {
            List<ISocialMission> newMissionList = new List<ISocialMission>();

            newMissionList.Add(new MissionShareALink(i_Model));
            newMissionList.Add(new MissionTagAFriendAndShareALink(i_Model));
            newMissionList.Add(new MissionTagFriendAndPost(i_Model));
            newMissionList.Add(new MissionUploadPhoto(i_Model));
            newMissionList.Add(new MissionWriteALongPost(i_Model));
            newMissionList.Add(new MissionWriteAPost(i_Model));

            LinkedList<ISocialMission> randomizedMissionList = randomizeMissionsOrder(newMissionList);
            return randomizedMissionList;
        }

        private static LinkedList<ISocialMission> randomizeMissionsOrder(List<ISocialMission> i_TempList)
        {
            LinkedList<ISocialMission> randomizedMissionList = new LinkedList<ISocialMission>();
            Random rand = new Random();
            ISocialMission tempMissionPlaceholder;
            int n = i_TempList.Count;
            while (n > 1)
            {
                n--;
                int i = rand.Next(n + 1);
                tempMissionPlaceholder = i_TempList[i];
                i_TempList[i] = i_TempList[n];
                i_TempList[n] = tempMissionPlaceholder;
            }

            foreach (ISocialMission tempMission in i_TempList)
            {
                randomizedMissionList.AddFirst(tempMission);
            }

            return randomizedMissionList;
        }
    }
}

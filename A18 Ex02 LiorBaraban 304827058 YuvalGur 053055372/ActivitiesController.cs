using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex02_Lior_Yuval
{
    internal class ActivitiesController
    {
        private PostedItem m_MostViralActivity;

        public PostedItem MostViralActivity
        {
            get { return m_MostViralActivity; }
        }

        public List<PostedItem> ActivityCollection { get; set; }

        public PostedItem GetViralActivity()
        {
            PostedItem mostLikedPostedItem = ActivityCollection[0];
            foreach (PostedItem postedItem in ActivityCollection)
            {
                if (postedItem.LikedBy.Count > mostLikedPostedItem.LikedBy.Count)
                {
                    mostLikedPostedItem = postedItem;
                }
            }

            m_MostViralActivity = mostLikedPostedItem;
            return mostLikedPostedItem;
        }
    }
}
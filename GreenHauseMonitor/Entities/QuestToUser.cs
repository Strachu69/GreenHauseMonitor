﻿using static Cmms.Dictionary.Dictionary;

namespace Cmms.Entities
{
    public class QuestToUser
    {
        public int Id { get; set; }
        public int QuestId { get; set; }
        public int UserId { get; set; }
        public UserInQuestResponsability userInQuestResponsability { get; set; } = UserInQuestResponsability.Observer;

        public virtual Quest Quest { get; set; }
        public virtual User User { get; set; }
    }
}

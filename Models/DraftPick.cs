 
 namespace DolphinDraftHistory.Models {
      public class DraftPick {    
        public int DraftPickId { get; set; }
        public int? Year { get; set; }
        public int? Rnd { get; set; }
        public string Player { get; set; }
        public string FriendlyPlayerName { get; set; }
        public int? Pick { get; set; }
        public string POS { get; set; }
        public int? To { get; set; }
        public int? Seasons { get; set; }
        public int? CarAV { get; set; }
        public int? Games { get; set; }
        public int? Passing_CMP { get; set; }
        public int? Passing_ATT { get; set; }
        public int? Passing_YDS { get; set; }
        public int? Passing_TD { get; set; }
        public int? Rushing_ATT { get; set; }
        public int? Rushing_YDS { get; set; }
        public int? Rushing_TD { get; set; }
        public int? Receiving_Rec { get; set; }
        public int? Receiving_YDS { get; set; }
        public int? Receiving_TD { get; set; }
        public int? Int{ get; set; }
        public decimal? SACKS { get; set; }
        public string College_Univ { get; set; }
    }
 }
 

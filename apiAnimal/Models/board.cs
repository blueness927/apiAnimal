//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace apiAnimal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class board
    {
        public int boardID { get; set; }
        public string boardTime { get; set; }
        public string board_userID { get; set; }
        public Nullable<int> board_animalID { get; set; }
        public string boardContent { get; set; }
    
        public virtual animalData animalData { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}

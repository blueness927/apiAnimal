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
    
    public partial class animalData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public animalData()
        {
            this.animalData_Pic = new HashSet<animalData_Pic>();
            this.animalData_Condition = new HashSet<animalData_Condition>();
            this.animalData_Condition1 = new HashSet<animalData_Condition>();
        }
    
        public int animalID { get; set; }
        public Nullable<int> animalData_animalTypeID { get; set; }
        public string animalName { get; set; }
        public string animalAddress { get; set; }
        public string animalDate { get; set; }
        public string animalGender { get; set; }
        public Nullable<int> animalAge { get; set; }
        public string animalColor { get; set; }
        public string animalBirth { get; set; }
        public string animalChip { get; set; }
        public string animalHealthy { get; set; }
        public string animalDisease_Other { get; set; }
        public Nullable<int> animalOwner_userID { get; set; }
        public string animalReason { get; set; }
        public Nullable<int> animalGetter_userID { get; set; }
        public string animalAdopted { get; set; }
        public string animalAdoptedDate { get; set; }
        public string animalNote { get; set; }
    
        public virtual animalData_Type animalData_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animalData_Pic> animalData_Pic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animalData_Condition> animalData_Condition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animalData_Condition> animalData_Condition1 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace apiAnimal.Models
{
    [MetadataType(typeof(animalDataMD))]
    public partial class animalData
    {
        public class animalDataMD
        {
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

            [JsonIgnore]
            public virtual animalData_Type animalData_Type { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

            [JsonIgnore]
            public virtual ICollection<animalData_Pic> animalData_Pic { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

            [JsonIgnore]
            public virtual ICollection<animalData_Condition> animalData_Condition { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

            [JsonIgnore]
            public virtual ICollection<animalData_Condition> animalData_Condition1 { get; set; }
        }
    }
}